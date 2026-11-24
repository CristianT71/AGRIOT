using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AGRIOT
{
    public partial class Dashboard : Form
    {
        private const int MaxPuntosGrafico = 60;
        private const int MaxFilasHistorial = 100;

        private static readonly Color ColorTemperatura = Color.FromArgb(219, 102, 53);
        private static readonly Color ColorHumedad = Color.FromArgb(49, 130, 171);

        private MqttService _mqtt;

        public string UsuarioActual
        {
            set { subtituloEncabezado.Text = "Bienvenido, " + value + " · lecturas de tu estación en tiempo real"; }
        }

        public Dashboard()
        {
            InitializeComponent();
            ConfigurarGrafico();
            ConfigurarTabla();
            topicInfo.Text = AppConfig.MqttTopic;

            Load += Dashboard_Load;
            FormClosed += Dashboard_FormClosed;
        }

        private void ConfigurarGrafico()
        {
            ChartArea area = grafico.ChartAreas[0];
            area.BackColor = Color.White;
            area.AxisX.LabelStyle.Enabled = false;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.MajorTickMark.Enabled = false;
            area.AxisX.LineColor = Tema.Borde;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(236, 240, 238);
            area.AxisY.MajorTickMark.Enabled = false;
            area.AxisY.LineColor = Color.Transparent;
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8.5F);
            area.AxisY.LabelStyle.ForeColor = Tema.TextoSuave;
            area.AxisY.IsStartedFromZero = false;

            grafico.Legends[0].Font = new Font("Segoe UI", 9F);
            grafico.Legends[0].ForeColor = Tema.Texto;
            grafico.Legends[0].BackColor = Color.Transparent;

            Series t = grafico.Series["Temperatura"];
            t.Color = ColorTemperatura;
            t.BorderWidth = 3;
            Series h = grafico.Series["Humedad"];
            h.Color = ColorHumedad;
            h.BorderWidth = 3;
        }

        private void ConfigurarTabla()
        {
            historial.BorderStyle = BorderStyle.None;
            historial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            historial.GridColor = Color.FromArgb(236, 240, 238);
            historial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            historial.EnableHeadersVisualStyles = false;
            historial.ColumnHeadersHeight = 38;
            historial.RowTemplate.Height = 34;

            historial.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            historial.ColumnHeadersDefaultCellStyle.ForeColor = Tema.TextoSuave;
            historial.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            historial.ColumnHeadersDefaultCellStyle.SelectionForeColor = Tema.TextoSuave;
            historial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F);
            historial.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            historial.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            historial.DefaultCellStyle.ForeColor = Tema.Texto;
            historial.DefaultCellStyle.BackColor = Color.White;
            historial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 243, 235);
            historial.DefaultCellStyle.SelectionForeColor = Tema.Texto;
            historial.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            historial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 251, 250);
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
            estadoBroker.Text = "●  Broker MQTT: " + detalle;
            if (conectado)
            {
                pildora.BackColor = Color.FromArgb(223, 244, 233);
                estadoBroker.ForeColor = Color.FromArgb(28, 110, 72);
            }
            else if (detalle.StartsWith("Error"))
            {
                pildora.BackColor = Color.FromArgb(252, 228, 228);
                estadoBroker.ForeColor = Color.FromArgb(170, 35, 35);
            }
            else
            {
                pildora.BackColor = Color.FromArgb(253, 240, 220);
                estadoBroker.ForeColor = Color.FromArgb(170, 100, 15);
            }
        }

        private void AplicarLectura(LecturaSensores l)
        {
            valorTemperatura.Text = l.Temperatura.HasValue ? $"{l.Temperatura.Value:0.0} °C" : "-- °C";
            valorHumedad.Text = l.Humedad.HasValue ? $"{l.Humedad.Value:0.0} %" : "-- %";
            valorUv.Text = l.IndiceUv.ToString("0.0");
            nivelUv.Text = "Nivel " + (l.CategoriaUv ?? "sin datos");
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

        private void exportar_Click(object sender, EventArgs e)
        {
            if (historial.Rows.Count == 0)
            {
                MessageBox.Show("Todavía no hay lecturas para exportar.", "Exportar historial",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo CSV (*.csv)|*.csv";
                dialogo.FileName = "historial_agriot_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                if (dialogo.ShowDialog(this) != DialogResult.OK) return;

                var sb = new StringBuilder();
                sb.AppendLine("Hora;Temperatura (C);Humedad (%);Indice UV");
                // El historial muestra lo más reciente arriba; se exporta en orden cronológico.
                for (int i = historial.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow fila = historial.Rows[i];
                    sb.AppendLine(string.Join(";", fila.Cells[0].Value, fila.Cells[1].Value,
                        fila.Cells[2].Value, fila.Cells[3].Value));
                }
                File.WriteAllText(dialogo.FileName, sb.ToString(), new UTF8Encoding(true));
            }
        }
    }
}
