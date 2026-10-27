using System;
using System.Drawing;
using System.Windows.Forms;

namespace AGRIOT
{
    public partial class Dashboard : Form
    {
        private const int MaxPuntosGrafico = 60;
        private const int MaxFilasHistorial = 100;

        private static readonly Color ColorConectado = Color.FromArgb(35, 116, 78);
        private static readonly Color ColorDesconectado = Color.FromArgb(196, 120, 25);
        private static readonly Color ColorError = Color.FromArgb(180, 40, 40);

        private MqttService _mqtt;

        public Dashboard()
        {
            InitializeComponent();

            Load += Dashboard_Load;
            FormClosed += Dashboard_FormClosed;
            grafico.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            _mqtt = new MqttService(AppConfig.MqttBroker, AppConfig.MqttPort, AppConfig.MqttTopic,
                AppConfig.MqttUsuario, AppConfig.MqttPassword);
            _mqtt.EstadoCambiado += (conectado, detalle) => EnUi(() => MostrarEstadoBroker(conectado, detalle));
            _mqtt.LecturaRecibida += lectura => EnUi(() => AplicarLectura(lectura));
            MostrarEstadoBroker(false, "Conectando...");
            await _mqtt.IniciarAsync();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mqtt?.Dispose();
        }

        // Los eventos de MQTT llegan desde hilos del ThreadPool.
        private void EnUi(Action accion)
        {
            if (IsDisposed || !IsHandleCreated) return;
            try { BeginInvoke(accion); }
            catch (InvalidOperationException) { /* el formulario se está cerrando */ }
        }

        private void MostrarEstadoBroker(bool conectado, string detalle)
        {
            estadoBroker.Text = "● Broker MQTT: " + detalle;
            estadoBroker.ForeColor = conectado ? ColorConectado
                : detalle.StartsWith("Error") ? ColorError
                : ColorDesconectado;
        }

        private void AplicarLectura(LecturaSensores l)
        {
            valorTemperatura.Text = l.Temperatura.HasValue ? $"{l.Temperatura.Value:0.0} °C" : "-- °C";
            valorHumedad.Text = l.Humedad.HasValue ? $"{l.Humedad.Value:0.0} %" : "-- %";
            valorUv.Text = l.IndiceUv.ToString("0.0");
            nivelUv.Text = "Nivel: " + (l.CategoriaUv ?? "Sin datos");
            nivelUv.Left = valorUv.Right + 8;
            valorVoltaje.Text = $"{l.VoltajeMv:0} mV";
            ultimaActualizacion.Text = "Última actualización: " + l.Recibida.ToString("HH:mm:ss") +
                                       (l.Retenida ? " (dato retenido)" : "");

            string hora = l.Recibida.ToString("HH:mm:ss");
            AgregarPunto("Temperatura", hora, l.Temperatura);
            AgregarPunto("Humedad", hora, l.Humedad);

            historial.Rows.Insert(0, hora,
                l.Temperatura.HasValue ? l.Temperatura.Value.ToString("0.0") : "--",
                l.Humedad.HasValue ? l.Humedad.Value.ToString("0.0") : "--",
                l.IndiceUv.ToString("0.0"));
            while (historial.Rows.Count > MaxFilasHistorial)
                historial.Rows.RemoveAt(historial.Rows.Count - 1);
        }

        private void AgregarPunto(string serie, string etiqueta, double? valor)
        {
            if (!valor.HasValue) return;
            var puntos = grafico.Series[serie].Points;
            puntos.AddXY(etiqueta, valor.Value);
            while (puntos.Count > MaxPuntosGrafico) puntos.RemoveAt(0);
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void panelVoltaje_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void valorTemperatura_Click(object sender, EventArgs e)
        {

        }
    }
}
