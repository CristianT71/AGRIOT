using System;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Formatter;
using MQTTnet.Protocol;
using Newtonsoft.Json;

namespace AGRIOT
{
    /// <summary>Cliente MQTT que se suscribe al topic de la estación y reconecta solo.</summary>
    public sealed class MqttService : IDisposable
    {
        private static readonly TimeSpan EsperaReconexion = TimeSpan.FromSeconds(5);

        private readonly string _broker;
        private readonly int _puerto;
        private readonly string _topic;
        private readonly IMqttClient _cliente;
        private readonly MqttClientOptions _opciones;
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private bool _reconectando;

        public event Action<LecturaSensores> LecturaRecibida;
        public event Action<bool, string> EstadoCambiado;   // (conectado, detalle)

        public MqttService(string broker, int puerto, string topic, string usuario, string password)
        {
            _broker = broker;
            _puerto = puerto;
            _topic = topic;

            _opciones = new MqttClientOptionsBuilder()
                .WithTcpServer(_broker, _puerto)
                .WithProtocolVersion(MqttProtocolVersion.V311)
                .WithCredentials(usuario, password)
                .WithTlsOptions(o => o.UseTls())
                .WithClientId("agriot-dashboard-" + Guid.NewGuid().ToString("N").Substring(0, 8))
                .WithCleanSession()
                .WithKeepAlivePeriod(TimeSpan.FromSeconds(30))
                .Build();

            _cliente = new MqttFactory().CreateMqttClient();
            _cliente.ApplicationMessageReceivedAsync += AlRecibirMensaje;
            _cliente.DisconnectedAsync += AlDesconectar;
        }

        public bool Conectado => _cliente.IsConnected;

        /// <summary>Conecta y suscribe; si falla deja el reintento en segundo plano.</summary>
        public async Task IniciarAsync()
        {
            if (!await IntentarConectarAsync())
                _ = ReconectarAsync();
        }

        private async Task<bool> IntentarConectarAsync()
        {
            try
            {
                await _cliente.ConnectAsync(_opciones, _cts.Token);
                await _cliente.SubscribeAsync(
                    // Al suscribirse el broker entrega el último mensaje retenido del topic;
                    // SendAtSubscribe lo hace explícito (aplica en MQTT 5, en 3.1.1 es el comportamiento estándar).
                    new MqttTopicFilterBuilder()
                        .WithTopic(_topic)
                        .WithAtLeastOnceQoS()
                        .WithRetainHandling(MqttRetainHandling.SendAtSubscribe)
                        .Build(),
                    _cts.Token);
                EstadoCambiado?.Invoke(true, "Conectado");
                return true;
            }
            catch (OperationCanceledException)
            {
                return false;
            }
            catch (Exception ex)
            {
                EstadoCambiado?.Invoke(false, "Error: " + ex.Message);
                return false;
            }
        }

        private Task AlDesconectar(MqttClientDisconnectedEventArgs e)
        {
            if (_cts.IsCancellationRequested) return Task.CompletedTask;
            EstadoCambiado?.Invoke(false, "Desconectado");
            _ = ReconectarAsync();
            return Task.CompletedTask;
        }

        private async Task ReconectarAsync()
        {
            if (_reconectando) return;
            _reconectando = true;
            try
            {
                while (!_cts.IsCancellationRequested && !_cliente.IsConnected)
                {
                    try { await Task.Delay(EsperaReconexion, _cts.Token); }
                    catch (OperationCanceledException) { return; }

                    EstadoCambiado?.Invoke(false, "Reconectando...");
                    if (await IntentarConectarAsync()) return;
                }
            }
            finally
            {
                _reconectando = false;
            }
        }

        private Task AlRecibirMensaje(MqttApplicationMessageReceivedEventArgs e)
        {
            try
            {
                string json = e.ApplicationMessage.ConvertPayloadToString();
                var lectura = JsonConvert.DeserializeObject<LecturaSensores>(json);
                if (lectura != null)
                {
                    lectura.Recibida = DateTime.Now;
                    lectura.Retenida = e.ApplicationMessage.Retain;
                    LecturaRecibida?.Invoke(lectura);
                }
            }
            catch (JsonException)
            {
                // Payload mal formado: se ignora para no tumbar la suscripción.
            }
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _cts.Cancel();
            try
            {
                if (_cliente.IsConnected)
                    _cliente.DisconnectAsync().Wait(TimeSpan.FromSeconds(2));
            }
            catch { }
            _cliente.Dispose();
            _cts.Dispose();
        }
    }
}
