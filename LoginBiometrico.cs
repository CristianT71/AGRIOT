using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json.Linq;

namespace AGRIOT
{
    public enum ModoBiometrico { Rostro, Pose, Voz }

    /// <summary>
    /// Inicio de sesión con modelos de Teachable Machine (TensorFlow.js) ejecutados en un WebView2.
    /// Rostro y pose: espera a que haya una persona frente a la cámara, la analiza durante 5 segundos y decide.
    /// Voz: confirma con varias lecturas seguidas. Solo entran las clases de <see cref="Permitidos"/>.
    /// </summary>
    public sealed class LoginBiometrico : Form
    {
        // Clases del grupo. Deben coincidir (sin importar mayúsculas) con los nombres en Teachable Machine.
        private static readonly string[] Permitidos = { "Violeta", "Kevin", "Cristian" };

        private const string Host = "agriot.local";

        // Rostro y pose
        private const int DuracionAnalisisMs = 5000;   // tiempo de análisis una vez detectada la cara
        private const int GraciaPresenciaMs = 700;     // cuánto se tolera perder la cara antes de reiniciar
        private const int MuestrasMinimas = 10;
        private const double FraccionMinima = 0.70;    // % de lecturas que deben coincidir con la misma persona
        private const double UmbralVision = 0.90;      // confianza mínima de cada lectura

        // Voz
        private const double UmbralVoz = 0.95;
        private const int LecturasVoz = 3;

        private readonly ModoBiometrico _modo;
        private readonly WebView2 _web = new WebView2();
        private readonly Label _estado = new Label();
        private readonly Panel _barraFondo = new Panel();
        private readonly Panel _barra = new Panel();
        private readonly Timer _reloj = new Timer { Interval = 100 };

        private readonly List<KeyValuePair<string, double>> _muestras = new List<KeyValuePair<string, double>>();
        private DateTime? _inicio;
        private DateTime _ultimaPresencia = DateTime.MinValue;
        private bool _bloqueado;

        private string _ultimaClaseVoz;
        private int _rachaVoz;

        public string UsuarioIdentificado { get; private set; }

        private string Carpeta => _modo == ModoBiometrico.Rostro ? "rostro" : _modo == ModoBiometrico.Pose ? "pose" : "voz";
        private string TextoEspera => _modo == ModoBiometrico.Pose ? "Colócate frente a la cámara" : "Acerca tu rostro a la cámara";

        public LoginBiometrico(ModoBiometrico modo)
        {
            _modo = modo;
            string nombre = modo == ModoBiometrico.Rostro ? "rostro" : modo == ModoBiometrico.Pose ? "pose" : "voz";

            Text = "AGRIOT - Iniciar sesión con " + nombre;
            ClientSize = new Size(440, 640);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9F);

            var titulo = new Label
            {
                Text = "Reconocimiento por " + nombre,
                Font = new Font("Segoe UI", 15F, FontStyle.Bold),
                ForeColor = Tema.Texto,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 56
            };

            var cancelar = new BotonRedondeado
            {
                Text = "Cancelar",
                BackColor = Color.FromArgb(236, 243, 239),
                ForeColor = Tema.Texto,
                ColorHover = Color.FromArgb(222, 233, 227),
                Size = new Size(160, 42),
                Anchor = AnchorStyles.Bottom
            };
            cancelar.Location = new Point((ClientSize.Width - cancelar.Width) / 2, ClientSize.Height - 66);
            cancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            _estado.AutoSize = false;
            _estado.TextAlign = ContentAlignment.MiddleCenter;
            _estado.Font = new Font("Segoe UI Semibold", 10.5F);
            _estado.ForeColor = Tema.TextoSuave;
            _estado.Text = "Iniciando…";
            _estado.Size = new Size(ClientSize.Width, 30);
            _estado.Location = new Point(0, ClientSize.Height - 104);

            // Barra de progreso de los 5 segundos (solo rostro y pose)
            _barraFondo.BackColor = Color.FromArgb(236, 243, 239);
            _barraFondo.Size = new Size(380, 6);
            _barraFondo.Location = new Point((ClientSize.Width - 380) / 2, ClientSize.Height - 118);
            _barraFondo.Visible = modo != ModoBiometrico.Voz;
            _barra.BackColor = Tema.Acento;
            _barra.Size = new Size(0, 6);
            _barraFondo.Controls.Add(_barra);

            _web.Location = new Point(0, 56);
            _web.Size = new Size(ClientSize.Width, ClientSize.Height - 56 - 126);
            _web.DefaultBackgroundColor = Color.White;

            Controls.Add(_web);
            Controls.Add(_barraFondo);
            Controls.Add(_estado);
            Controls.Add(cancelar);
            Controls.Add(titulo);

            CancelButton = cancelar;
            _reloj.Tick += (s, e) => AlTick();
            FormClosed += (s, e) => { _reloj.Stop(); _reloj.Dispose(); _web.Dispose(); };   // libera cámara y micrófono
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await IniciarAsync();
        }

        private async Task IniciarAsync()
        {
            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            string modelo = Path.Combine(raiz, "Modelos", Carpeta, "model.json");
            if (!File.Exists(modelo))
            {
                MostrarError("Falta el modelo. Copia model.json, metadata.json y weights.bin en:\nModelos\\" + Carpeta);
                return;
            }

            try
            {
                string datos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "AGRIOT", "WebView2");
                CoreWebView2Environment env = await CoreWebView2Environment.CreateAsync(null, datos);
                await _web.EnsureCoreWebView2Async(env);
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo iniciar WebView2. Instala el runtime de Microsoft Edge WebView2.\n" + ex.Message);
                return;
            }

            CoreWebView2 core = _web.CoreWebView2;
            core.Settings.AreDevToolsEnabled = false;
            core.Settings.AreDefaultContextMenusEnabled = false;
            core.PermissionRequested += (s, a) =>
            {
                if (a.PermissionKind == CoreWebView2PermissionKind.Camera ||
                    a.PermissionKind == CoreWebView2PermissionKind.Microphone)
                    a.State = CoreWebView2PermissionState.Allow;
            };
            core.WebMessageReceived += AlRecibirMensaje;
            core.SetVirtualHostNameToFolderMapping(Host, raiz, CoreWebView2HostResourceAccessKind.Allow);
            core.Navigate("https://" + Host + "/Web/tm_login.html?modo=" + Carpeta);
            _estado.Text = "Cargando modelo…";
        }

        private void AlRecibirMensaje(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            JObject msg;
            try { msg = JObject.Parse(e.WebMessageAsJson); }
            catch { return; }

            switch ((string)msg["tipo"])
            {
                case "error":
                    MostrarError((string)msg["mensaje"]);
                    break;

                case "listo":
                    if (_modo == ModoBiometrico.Voz)
                    {
                        _estado.Text = "Di tu nombre en voz alta";
                    }
                    else
                    {
                        _estado.Text = TextoEspera;
                        _reloj.Start();
                    }
                    break;

                case "presencia":
                    if (_modo != ModoBiometrico.Voz && !_bloqueado && (bool)msg["hay"])
                    {
                        _ultimaPresencia = DateTime.Now;
                        if (!_inicio.HasValue)
                        {
                            _inicio = DateTime.Now;
                            _muestras.Clear();
                        }
                    }
                    break;

                case "prediccion":
                    var mejor = ((JArray)msg["predicciones"])
                        .Select(p => new { Clase = (string)p["clase"], Prob = (double)p["prob"] })
                        .OrderByDescending(p => p.Prob)
                        .FirstOrDefault();
                    if (mejor == null) break;

                    if (_modo == ModoBiometrico.Voz)
                        EvaluarVoz(mejor.Clase, mejor.Prob);
                    else if (_inicio.HasValue && !_bloqueado)
                    {
                        _ultimaPresencia = DateTime.Now;   // si llegan predicciones es porque hay persona
                        _muestras.Add(new KeyValuePair<string, double>(mejor.Clase, mejor.Prob));
                    }
                    break;
            }
        }

        // ---------- Rostro y pose: 5 segundos con la persona presente ----------

        private void AlTick()
        {
            if (_bloqueado || !_inicio.HasValue) return;

            DateTime ahora = DateTime.Now;
            if ((ahora - _ultimaPresencia).TotalMilliseconds > GraciaPresenciaMs)
            {
                ReiniciarEspera();
                return;
            }

            double transcurrido = (ahora - _inicio.Value).TotalMilliseconds;
            _barra.Width = (int)(_barraFondo.Width * Math.Min(1.0, transcurrido / DuracionAnalisisMs));
            _estado.ForeColor = Tema.Acento;
            _estado.Text = "Analizando…  " + Math.Max(0, (int)Math.Ceiling((DuracionAnalisisMs - transcurrido) / 1000.0)) + " s";

            if (transcurrido >= DuracionAnalisisMs) Decidir();
        }

        private void ReiniciarEspera()
        {
            _inicio = null;
            _muestras.Clear();
            _barra.Width = 0;
            _estado.ForeColor = Tema.TextoSuave;
            _estado.Text = TextoEspera;
        }

        private async void Decidir()
        {
            _bloqueado = true;
            _barra.Width = _barraFondo.Width;

            string ganador = null;
            double fraccion = 0;
            if (_muestras.Count >= MuestrasMinimas)
            {
                var conteo = Permitidos
                    .Select(p => new
                    {
                        Nombre = p,
                        Aciertos = _muestras.Count(m => string.Equals(m.Key, p, StringComparison.OrdinalIgnoreCase)
                                                        && m.Value >= UmbralVision)
                    })
                    .OrderByDescending(x => x.Aciertos)
                    .First();
                fraccion = (double)conteo.Aciertos / _muestras.Count;
                if (fraccion >= FraccionMinima) ganador = conteo.Nombre;
            }

            if (ganador != null)
            {
                _estado.ForeColor = Color.FromArgb(28, 110, 72);
                _estado.Text = "Bienvenido, " + ganador;
                await Task.Delay(700);
                if (IsDisposed) return;
                UsuarioIdentificado = ganador;
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            _estado.ForeColor = Color.FromArgb(170, 35, 35);
            _estado.Text = "No se pudo verificar tu identidad. Intenta de nuevo";
            await Task.Delay(2500);
            if (IsDisposed) return;
            _bloqueado = false;
            ReiniciarEspera();
        }

        // ---------- Voz: lecturas seguidas ----------

        private void EvaluarVoz(string clase, double prob)
        {
            bool esPermitida = Permitidos.Contains(clase, StringComparer.OrdinalIgnoreCase);
            bool esOtros = string.Equals(clase, "Otros", StringComparison.OrdinalIgnoreCase);

            // El ruido de fondo no cuenta ni a favor ni en contra.
            if (!esPermitida && !esOtros) return;

            if (!esPermitida || prob < UmbralVoz)
            {
                _rachaVoz = 0;
                _ultimaClaseVoz = null;
                _estado.ForeColor = esOtros && prob >= UmbralVoz ? Color.FromArgb(170, 35, 35) : Tema.TextoSuave;
                _estado.Text = esOtros && prob >= UmbralVoz ? "Voz no autorizada" : "Di tu nombre en voz alta";
                return;
            }

            if (!string.Equals(clase, _ultimaClaseVoz, StringComparison.OrdinalIgnoreCase))
            {
                _ultimaClaseVoz = clase;
                _rachaVoz = 0;
            }
            _rachaVoz++;
            _estado.ForeColor = Color.FromArgb(28, 110, 72);
            _estado.Text = "Verificando…";

            if (_rachaVoz >= LecturasVoz)
            {
                UsuarioIdentificado = Permitidos.First(p => string.Equals(p, clase, StringComparison.OrdinalIgnoreCase));
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void MostrarError(string texto)
        {
            _reloj.Stop();
            _barraFondo.Visible = false;
            _estado.ForeColor = Color.FromArgb(170, 35, 35);
            _estado.Text = texto;
            _estado.Height = 56;
            _estado.Top = ClientSize.Height - 130;
        }
    }
}
