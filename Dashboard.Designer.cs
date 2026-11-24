namespace AGRIOT
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indiceUv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuLateral = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.lema = new System.Windows.Forms.Label();
            this.menuDashboard = new AGRIOT.BotonRedondeado();
            this.menuHistorial = new AGRIOT.BotonRedondeado();
            this.menuConfiguracion = new AGRIOT.BotonRedondeado();
            this.pieMenu = new System.Windows.Forms.Panel();
            this.etiquetaTopic = new System.Windows.Forms.Label();
            this.topicInfo = new System.Windows.Forms.Label();
            this.contenido = new System.Windows.Forms.Panel();
            this.rejilla = new System.Windows.Forms.TableLayoutPanel();
            this.encabezado = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.subtituloEncabezado = new System.Windows.Forms.Label();
            this.panelEstado = new System.Windows.Forms.Panel();
            this.pildora = new AGRIOT.PanelRedondeado();
            this.estadoBroker = new System.Windows.Forms.Label();
            this.ultimaActualizacion = new System.Windows.Forms.Label();
            this.panelTemperatura = new AGRIOT.PanelRedondeado();
            this.insigniaTemperatura = new AGRIOT.PanelRedondeado();
            this.simboloTemperatura = new System.Windows.Forms.Label();
            this.textoTemperatura = new System.Windows.Forms.Label();
            this.valorTemperatura = new System.Windows.Forms.Label();
            this.panelHumedad = new AGRIOT.PanelRedondeado();
            this.insigniaHumedad = new AGRIOT.PanelRedondeado();
            this.simboloHumedad = new System.Windows.Forms.Label();
            this.textoHumedad = new System.Windows.Forms.Label();
            this.valorHumedad = new System.Windows.Forms.Label();
            this.panelUv = new AGRIOT.PanelRedondeado();
            this.insigniaUv = new AGRIOT.PanelRedondeado();
            this.simboloUv = new System.Windows.Forms.Label();
            this.textoUv = new System.Windows.Forms.Label();
            this.valorUv = new System.Windows.Forms.Label();
            this.nivelUv = new System.Windows.Forms.Label();
            this.panelVoltaje = new AGRIOT.PanelRedondeado();
            this.insigniaVoltaje = new AGRIOT.PanelRedondeado();
            this.simboloVoltaje = new System.Windows.Forms.Label();
            this.textoVoltaje = new System.Windows.Forms.Label();
            this.valorVoltaje = new System.Windows.Forms.Label();
            this.panelGrafico = new AGRIOT.PanelRedondeado();
            this.tituloGrafico = new System.Windows.Forms.Label();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHistorial = new AGRIOT.PanelRedondeado();
            this.cabeceraHistorial = new System.Windows.Forms.Panel();
            this.tituloHistorial = new System.Windows.Forms.Label();
            this.exportar = new AGRIOT.BotonRedondeado();
            this.historial = new System.Windows.Forms.DataGridView();
            this.menuLateral.SuspendLayout();
            this.pieMenu.SuspendLayout();
            this.contenido.SuspendLayout();
            this.rejilla.SuspendLayout();
            this.encabezado.SuspendLayout();
            this.panelEstado.SuspendLayout();
            this.pildora.SuspendLayout();
            this.panelTemperatura.SuspendLayout();
            this.insigniaTemperatura.SuspendLayout();
            this.panelHumedad.SuspendLayout();
            this.insigniaHumedad.SuspendLayout();
            this.panelUv.SuspendLayout();
            this.insigniaUv.SuspendLayout();
            this.panelVoltaje.SuspendLayout();
            this.insigniaVoltaje.SuspendLayout();
            this.panelGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.panelHistorial.SuspendLayout();
            this.cabeceraHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historial)).BeginInit();
            this.SuspendLayout();
            //
            // hora
            //
            this.hora.HeaderText = "Hora";
            this.hora.MinimumWidth = 6;
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            //
            // temperatura
            //
            this.temperatura.HeaderText = "Temp. (°C)";
            this.temperatura.MinimumWidth = 6;
            this.temperatura.Name = "temperatura";
            this.temperatura.ReadOnly = true;
            //
            // humedad
            //
            this.humedad.HeaderText = "Humedad (%)";
            this.humedad.MinimumWidth = 6;
            this.humedad.Name = "humedad";
            this.humedad.ReadOnly = true;
            //
            // indiceUv
            //
            this.indiceUv.HeaderText = "Índice UV";
            this.indiceUv.MinimumWidth = 6;
            this.indiceUv.Name = "indiceUv";
            this.indiceUv.ReadOnly = true;
            //
            // menuLateral
            //
            this.menuLateral.BackColor = System.Drawing.Color.FromArgb(16, 44, 34);
            this.menuLateral.Controls.Add(this.logo);
            this.menuLateral.Controls.Add(this.lema);
            this.menuLateral.Controls.Add(this.menuDashboard);
            this.menuLateral.Controls.Add(this.menuHistorial);
            this.menuLateral.Controls.Add(this.menuConfiguracion);
            this.menuLateral.Controls.Add(this.pieMenu);
            this.menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral.Location = new System.Drawing.Point(0, 0);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(230, 800);
            this.menuLateral.TabIndex = 0;
            //
            // logo
            //
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.Location = new System.Drawing.Point(22, 26);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(130, 37);
            this.logo.TabIndex = 0;
            this.logo.Text = "AGRIOT";
            //
            // lema
            //
            this.lema.AutoSize = true;
            this.lema.BackColor = System.Drawing.Color.Transparent;
            this.lema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lema.ForeColor = System.Drawing.Color.FromArgb(143, 183, 163);
            this.lema.Location = new System.Drawing.Point(25, 64);
            this.lema.Name = "lema";
            this.lema.Size = new System.Drawing.Size(120, 15);
            this.lema.TabIndex = 1;
            this.lema.Text = "Agricultura inteligente";
            //
            // menuDashboard
            //
            this.menuDashboard.BackColor = System.Drawing.Color.FromArgb(33, 82, 62);
            this.menuDashboard.ColorHover = System.Drawing.Color.FromArgb(38, 94, 71);
            this.menuDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.menuDashboard.ForeColor = System.Drawing.Color.White;
            this.menuDashboard.Location = new System.Drawing.Point(16, 124);
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.menuDashboard.Size = new System.Drawing.Size(198, 44);
            this.menuDashboard.TabIndex = 1;
            this.menuDashboard.Text = "Panel principal";
            this.menuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuDashboard.UseVisualStyleBackColor = false;
            //
            // menuHistorial
            //
            this.menuHistorial.BackColor = System.Drawing.Color.Transparent;
            this.menuHistorial.ColorHover = System.Drawing.Color.FromArgb(24, 62, 48);
            this.menuHistorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuHistorial.ForeColor = System.Drawing.Color.FromArgb(200, 224, 211);
            this.menuHistorial.Location = new System.Drawing.Point(16, 176);
            this.menuHistorial.Name = "menuHistorial";
            this.menuHistorial.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.menuHistorial.Size = new System.Drawing.Size(198, 44);
            this.menuHistorial.TabIndex = 2;
            this.menuHistorial.Text = "Historial";
            this.menuHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuHistorial.UseVisualStyleBackColor = false;
            //
            // menuConfiguracion
            //
            this.menuConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.menuConfiguracion.ColorHover = System.Drawing.Color.FromArgb(24, 62, 48);
            this.menuConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuConfiguracion.ForeColor = System.Drawing.Color.FromArgb(200, 224, 211);
            this.menuConfiguracion.Location = new System.Drawing.Point(16, 228);
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.menuConfiguracion.Size = new System.Drawing.Size(198, 44);
            this.menuConfiguracion.TabIndex = 3;
            this.menuConfiguracion.Text = "Configuración";
            this.menuConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuConfiguracion.UseVisualStyleBackColor = false;
            //
            // pieMenu
            //
            this.pieMenu.Controls.Add(this.etiquetaTopic);
            this.pieMenu.Controls.Add(this.topicInfo);
            this.pieMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pieMenu.Location = new System.Drawing.Point(0, 720);
            this.pieMenu.Name = "pieMenu";
            this.pieMenu.Size = new System.Drawing.Size(230, 80);
            this.pieMenu.TabIndex = 4;
            //
            // etiquetaTopic
            //
            this.etiquetaTopic.AutoSize = true;
            this.etiquetaTopic.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.etiquetaTopic.ForeColor = System.Drawing.Color.FromArgb(143, 183, 163);
            this.etiquetaTopic.Location = new System.Drawing.Point(24, 18);
            this.etiquetaTopic.Name = "etiquetaTopic";
            this.etiquetaTopic.Size = new System.Drawing.Size(70, 13);
            this.etiquetaTopic.TabIndex = 0;
            this.etiquetaTopic.Text = "TOPIC MQTT";
            //
            // topicInfo
            //
            this.topicInfo.AutoEllipsis = true;
            this.topicInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.topicInfo.ForeColor = System.Drawing.Color.White;
            this.topicInfo.Location = new System.Drawing.Point(24, 36);
            this.topicInfo.Name = "topicInfo";
            this.topicInfo.Size = new System.Drawing.Size(190, 20);
            this.topicInfo.TabIndex = 1;
            this.topicInfo.Text = "agro/estacion/sensores";
            //
            // contenido
            //
            this.contenido.BackColor = System.Drawing.Color.FromArgb(243, 246, 244);
            this.contenido.Controls.Add(this.rejilla);
            this.contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenido.Location = new System.Drawing.Point(230, 0);
            this.contenido.Name = "contenido";
            this.contenido.Padding = new System.Windows.Forms.Padding(20, 18, 20, 14);
            this.contenido.Size = new System.Drawing.Size(1130, 800);
            this.contenido.TabIndex = 1;
            //
            // rejilla
            //
            this.rejilla.ColumnCount = 4;
            this.rejilla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rejilla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rejilla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rejilla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rejilla.Controls.Add(this.encabezado, 0, 0);
            this.rejilla.Controls.Add(this.panelTemperatura, 0, 1);
            this.rejilla.Controls.Add(this.panelHumedad, 1, 1);
            this.rejilla.Controls.Add(this.panelUv, 2, 1);
            this.rejilla.Controls.Add(this.panelVoltaje, 3, 1);
            this.rejilla.Controls.Add(this.panelGrafico, 0, 2);
            this.rejilla.Controls.Add(this.panelHistorial, 2, 2);
            this.rejilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rejilla.Location = new System.Drawing.Point(20, 18);
            this.rejilla.Name = "rejilla";
            this.rejilla.RowCount = 3;
            this.rejilla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.rejilla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.rejilla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rejilla.Size = new System.Drawing.Size(1090, 768);
            this.rejilla.TabIndex = 0;
            this.rejilla.SetColumnSpan(this.encabezado, 4);
            this.rejilla.SetColumnSpan(this.panelGrafico, 2);
            this.rejilla.SetColumnSpan(this.panelHistorial, 2);
            //
            // encabezado
            //
            this.encabezado.Controls.Add(this.titulo);
            this.encabezado.Controls.Add(this.subtituloEncabezado);
            this.encabezado.Controls.Add(this.panelEstado);
            this.encabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encabezado.Location = new System.Drawing.Point(3, 3);
            this.encabezado.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.encabezado.Name = "encabezado";
            this.encabezado.Size = new System.Drawing.Size(1074, 76);
            this.encabezado.TabIndex = 0;
            //
            // titulo
            //
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.titulo.Location = new System.Drawing.Point(-2, 2);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(230, 41);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Panel principal";
            //
            // subtituloEncabezado
            //
            this.subtituloEncabezado.AutoSize = true;
            this.subtituloEncabezado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subtituloEncabezado.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.subtituloEncabezado.Location = new System.Drawing.Point(1, 46);
            this.subtituloEncabezado.Name = "subtituloEncabezado";
            this.subtituloEncabezado.Size = new System.Drawing.Size(260, 19);
            this.subtituloEncabezado.TabIndex = 1;
            this.subtituloEncabezado.Text = "Lecturas de tu estación en tiempo real";
            //
            // panelEstado
            //
            this.panelEstado.Controls.Add(this.pildora);
            this.panelEstado.Controls.Add(this.ultimaActualizacion);
            this.panelEstado.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEstado.Location = new System.Drawing.Point(724, 0);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(350, 76);
            this.panelEstado.TabIndex = 2;
            //
            // pildora
            //
            this.pildora.BackColor = System.Drawing.Color.FromArgb(253, 240, 220);
            this.pildora.Controls.Add(this.estadoBroker);
            this.pildora.Location = new System.Drawing.Point(90, 6);
            this.pildora.Name = "pildora";
            this.pildora.Radio = 17;
            this.pildora.Sombra = false;
            this.pildora.Size = new System.Drawing.Size(260, 34);
            this.pildora.TabIndex = 0;
            //
            // estadoBroker
            //
            this.estadoBroker.AutoEllipsis = true;
            this.estadoBroker.BackColor = System.Drawing.Color.Transparent;
            this.estadoBroker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estadoBroker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.estadoBroker.ForeColor = System.Drawing.Color.FromArgb(170, 100, 15);
            this.estadoBroker.Location = new System.Drawing.Point(0, 0);
            this.estadoBroker.Name = "estadoBroker";
            this.estadoBroker.Size = new System.Drawing.Size(260, 34);
            this.estadoBroker.TabIndex = 0;
            this.estadoBroker.Text = "● Broker MQTT: Desconectado";
            this.estadoBroker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ultimaActualizacion
            //
            this.ultimaActualizacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ultimaActualizacion.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.ultimaActualizacion.Location = new System.Drawing.Point(0, 46);
            this.ultimaActualizacion.Name = "ultimaActualizacion";
            this.ultimaActualizacion.Size = new System.Drawing.Size(350, 20);
            this.ultimaActualizacion.TabIndex = 1;
            this.ultimaActualizacion.Text = "Última actualización: sin datos todavía";
            this.ultimaActualizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // panelTemperatura
            //
            this.panelTemperatura.Controls.Add(this.insigniaTemperatura);
            this.panelTemperatura.Controls.Add(this.textoTemperatura);
            this.panelTemperatura.Controls.Add(this.valorTemperatura);
            this.panelTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTemperatura.Location = new System.Drawing.Point(11, 85);
            this.panelTemperatura.Margin = new System.Windows.Forms.Padding(8);
            this.panelTemperatura.Name = "panelTemperatura";
            this.panelTemperatura.Size = new System.Drawing.Size(256, 124);
            this.panelTemperatura.TabIndex = 1;
            //
            // insigniaTemperatura
            //
            this.insigniaTemperatura.BackColor = System.Drawing.Color.FromArgb(252, 236, 229);
            this.insigniaTemperatura.Controls.Add(this.simboloTemperatura);
            this.insigniaTemperatura.Location = new System.Drawing.Point(18, 18);
            this.insigniaTemperatura.Name = "insigniaTemperatura";
            this.insigniaTemperatura.Radio = 12;
            this.insigniaTemperatura.Sombra = false;
            this.insigniaTemperatura.Size = new System.Drawing.Size(40, 40);
            this.insigniaTemperatura.TabIndex = 0;
            //
            // simboloTemperatura
            //
            this.simboloTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.simboloTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simboloTemperatura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.simboloTemperatura.ForeColor = System.Drawing.Color.FromArgb(219, 102, 53);
            this.simboloTemperatura.Name = "simboloTemperatura";
            this.simboloTemperatura.Size = new System.Drawing.Size(40, 40);
            this.simboloTemperatura.TabIndex = 0;
            this.simboloTemperatura.Text = "°C";
            this.simboloTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // textoTemperatura
            //
            this.textoTemperatura.AutoSize = true;
            this.textoTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.textoTemperatura.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textoTemperatura.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.textoTemperatura.Location = new System.Drawing.Point(68, 28);
            this.textoTemperatura.Name = "textoTemperatura";
            this.textoTemperatura.Size = new System.Drawing.Size(88, 19);
            this.textoTemperatura.TabIndex = 1;
            this.textoTemperatura.Text = "Temperatura";
            //
            // valorTemperatura
            //
            this.valorTemperatura.AutoSize = true;
            this.valorTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.valorTemperatura.Font = new System.Drawing.Font("Segoe UI Semibold", 26F);
            this.valorTemperatura.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.valorTemperatura.Location = new System.Drawing.Point(14, 64);
            this.valorTemperatura.Name = "valorTemperatura";
            this.valorTemperatura.Size = new System.Drawing.Size(110, 47);
            this.valorTemperatura.TabIndex = 2;
            this.valorTemperatura.Text = "-- °C";
            //
            // panelHumedad
            //
            this.panelHumedad.Controls.Add(this.insigniaHumedad);
            this.panelHumedad.Controls.Add(this.textoHumedad);
            this.panelHumedad.Controls.Add(this.valorHumedad);
            this.panelHumedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHumedad.Location = new System.Drawing.Point(283, 85);
            this.panelHumedad.Margin = new System.Windows.Forms.Padding(8);
            this.panelHumedad.Name = "panelHumedad";
            this.panelHumedad.Size = new System.Drawing.Size(256, 124);
            this.panelHumedad.TabIndex = 2;
            //
            // insigniaHumedad
            //
            this.insigniaHumedad.BackColor = System.Drawing.Color.FromArgb(228, 241, 248);
            this.insigniaHumedad.Controls.Add(this.simboloHumedad);
            this.insigniaHumedad.Location = new System.Drawing.Point(18, 18);
            this.insigniaHumedad.Name = "insigniaHumedad";
            this.insigniaHumedad.Radio = 12;
            this.insigniaHumedad.Sombra = false;
            this.insigniaHumedad.Size = new System.Drawing.Size(40, 40);
            this.insigniaHumedad.TabIndex = 0;
            //
            // simboloHumedad
            //
            this.simboloHumedad.BackColor = System.Drawing.Color.Transparent;
            this.simboloHumedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simboloHumedad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.simboloHumedad.ForeColor = System.Drawing.Color.FromArgb(49, 130, 171);
            this.simboloHumedad.Name = "simboloHumedad";
            this.simboloHumedad.Size = new System.Drawing.Size(40, 40);
            this.simboloHumedad.TabIndex = 0;
            this.simboloHumedad.Text = "%";
            this.simboloHumedad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // textoHumedad
            //
            this.textoHumedad.AutoSize = true;
            this.textoHumedad.BackColor = System.Drawing.Color.Transparent;
            this.textoHumedad.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textoHumedad.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.textoHumedad.Location = new System.Drawing.Point(68, 28);
            this.textoHumedad.Name = "textoHumedad";
            this.textoHumedad.Size = new System.Drawing.Size(98, 19);
            this.textoHumedad.TabIndex = 1;
            this.textoHumedad.Text = "Humedad relativa";
            //
            // valorHumedad
            //
            this.valorHumedad.AutoSize = true;
            this.valorHumedad.BackColor = System.Drawing.Color.Transparent;
            this.valorHumedad.Font = new System.Drawing.Font("Segoe UI Semibold", 26F);
            this.valorHumedad.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.valorHumedad.Location = new System.Drawing.Point(14, 64);
            this.valorHumedad.Name = "valorHumedad";
            this.valorHumedad.Size = new System.Drawing.Size(100, 47);
            this.valorHumedad.TabIndex = 2;
            this.valorHumedad.Text = "-- %";
            //
            // panelUv
            //
            this.panelUv.Controls.Add(this.insigniaUv);
            this.panelUv.Controls.Add(this.textoUv);
            this.panelUv.Controls.Add(this.valorUv);
            this.panelUv.Controls.Add(this.nivelUv);
            this.panelUv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUv.Location = new System.Drawing.Point(555, 85);
            this.panelUv.Margin = new System.Windows.Forms.Padding(8);
            this.panelUv.Name = "panelUv";
            this.panelUv.Size = new System.Drawing.Size(256, 124);
            this.panelUv.TabIndex = 3;
            //
            // insigniaUv
            //
            this.insigniaUv.BackColor = System.Drawing.Color.FromArgb(240, 232, 246);
            this.insigniaUv.Controls.Add(this.simboloUv);
            this.insigniaUv.Location = new System.Drawing.Point(18, 18);
            this.insigniaUv.Name = "insigniaUv";
            this.insigniaUv.Radio = 12;
            this.insigniaUv.Sombra = false;
            this.insigniaUv.Size = new System.Drawing.Size(40, 40);
            this.insigniaUv.TabIndex = 0;
            //
            // simboloUv
            //
            this.simboloUv.BackColor = System.Drawing.Color.Transparent;
            this.simboloUv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simboloUv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.simboloUv.ForeColor = System.Drawing.Color.FromArgb(142, 91, 171);
            this.simboloUv.Name = "simboloUv";
            this.simboloUv.Size = new System.Drawing.Size(40, 40);
            this.simboloUv.TabIndex = 0;
            this.simboloUv.Text = "UV";
            this.simboloUv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // textoUv
            //
            this.textoUv.AutoSize = true;
            this.textoUv.BackColor = System.Drawing.Color.Transparent;
            this.textoUv.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textoUv.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.textoUv.Location = new System.Drawing.Point(68, 28);
            this.textoUv.Name = "textoUv";
            this.textoUv.Size = new System.Drawing.Size(70, 19);
            this.textoUv.TabIndex = 1;
            this.textoUv.Text = "Índice UV";
            //
            // valorUv
            //
            this.valorUv.AutoSize = true;
            this.valorUv.BackColor = System.Drawing.Color.Transparent;
            this.valorUv.Font = new System.Drawing.Font("Segoe UI Semibold", 26F);
            this.valorUv.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.valorUv.Location = new System.Drawing.Point(14, 64);
            this.valorUv.Name = "valorUv";
            this.valorUv.Size = new System.Drawing.Size(50, 47);
            this.valorUv.TabIndex = 2;
            this.valorUv.Text = "--";
            //
            // nivelUv
            //
            this.nivelUv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nivelUv.BackColor = System.Drawing.Color.Transparent;
            this.nivelUv.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.nivelUv.ForeColor = System.Drawing.Color.FromArgb(142, 91, 171);
            this.nivelUv.Location = new System.Drawing.Point(130, 82);
            this.nivelUv.Name = "nivelUv";
            this.nivelUv.Size = new System.Drawing.Size(110, 20);
            this.nivelUv.TabIndex = 3;
            this.nivelUv.Text = "Sin datos";
            this.nivelUv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // panelVoltaje
            //
            this.panelVoltaje.Controls.Add(this.insigniaVoltaje);
            this.panelVoltaje.Controls.Add(this.textoVoltaje);
            this.panelVoltaje.Controls.Add(this.valorVoltaje);
            this.panelVoltaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVoltaje.Location = new System.Drawing.Point(827, 85);
            this.panelVoltaje.Margin = new System.Windows.Forms.Padding(8);
            this.panelVoltaje.Name = "panelVoltaje";
            this.panelVoltaje.Size = new System.Drawing.Size(256, 124);
            this.panelVoltaje.TabIndex = 4;
            //
            // insigniaVoltaje
            //
            this.insigniaVoltaje.BackColor = System.Drawing.Color.FromArgb(230, 238, 240);
            this.insigniaVoltaje.Controls.Add(this.simboloVoltaje);
            this.insigniaVoltaje.Location = new System.Drawing.Point(18, 18);
            this.insigniaVoltaje.Name = "insigniaVoltaje";
            this.insigniaVoltaje.Radio = 12;
            this.insigniaVoltaje.Sombra = false;
            this.insigniaVoltaje.Size = new System.Drawing.Size(40, 40);
            this.insigniaVoltaje.TabIndex = 0;
            //
            // simboloVoltaje
            //
            this.simboloVoltaje.BackColor = System.Drawing.Color.Transparent;
            this.simboloVoltaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simboloVoltaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.simboloVoltaje.ForeColor = System.Drawing.Color.FromArgb(69, 112, 124);
            this.simboloVoltaje.Name = "simboloVoltaje";
            this.simboloVoltaje.Size = new System.Drawing.Size(40, 40);
            this.simboloVoltaje.TabIndex = 0;
            this.simboloVoltaje.Text = "mV";
            this.simboloVoltaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // textoVoltaje
            //
            this.textoVoltaje.AutoSize = true;
            this.textoVoltaje.BackColor = System.Drawing.Color.Transparent;
            this.textoVoltaje.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textoVoltaje.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.textoVoltaje.Location = new System.Drawing.Point(68, 28);
            this.textoVoltaje.Name = "textoVoltaje";
            this.textoVoltaje.Size = new System.Drawing.Size(120, 19);
            this.textoVoltaje.TabIndex = 1;
            this.textoVoltaje.Text = "Voltaje sensor UV";
            //
            // valorVoltaje
            //
            this.valorVoltaje.AutoSize = true;
            this.valorVoltaje.BackColor = System.Drawing.Color.Transparent;
            this.valorVoltaje.Font = new System.Drawing.Font("Segoe UI Semibold", 26F);
            this.valorVoltaje.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.valorVoltaje.Location = new System.Drawing.Point(14, 64);
            this.valorVoltaje.Name = "valorVoltaje";
            this.valorVoltaje.Size = new System.Drawing.Size(120, 47);
            this.valorVoltaje.TabIndex = 2;
            this.valorVoltaje.Text = "-- mV";
            //
            // panelGrafico
            //
            this.panelGrafico.Controls.Add(this.grafico);
            this.panelGrafico.Controls.Add(this.tituloGrafico);
            this.panelGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrafico.Location = new System.Drawing.Point(11, 225);
            this.panelGrafico.Margin = new System.Windows.Forms.Padding(8);
            this.panelGrafico.Name = "panelGrafico";
            this.panelGrafico.Padding = new System.Windows.Forms.Padding(20, 16, 20, 20);
            this.panelGrafico.Size = new System.Drawing.Size(528, 532);
            this.panelGrafico.TabIndex = 5;
            //
            // tituloGrafico
            //
            this.tituloGrafico.BackColor = System.Drawing.Color.Transparent;
            this.tituloGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloGrafico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tituloGrafico.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.tituloGrafico.Location = new System.Drawing.Point(20, 16);
            this.tituloGrafico.Name = "tituloGrafico";
            this.tituloGrafico.Size = new System.Drawing.Size(488, 34);
            this.tituloGrafico.TabIndex = 0;
            this.tituloGrafico.Text = "Temperatura y humedad";
            this.tituloGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // grafico
            //
            this.grafico.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            this.grafico.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(20, 50);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Humedad";
            this.grafico.Series.Add(series1);
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(488, 462);
            this.grafico.TabIndex = 1;
            //
            // panelHistorial
            //
            this.panelHistorial.Controls.Add(this.historial);
            this.panelHistorial.Controls.Add(this.cabeceraHistorial);
            this.panelHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistorial.Location = new System.Drawing.Point(555, 225);
            this.panelHistorial.Margin = new System.Windows.Forms.Padding(8);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Padding = new System.Windows.Forms.Padding(20, 16, 20, 20);
            this.panelHistorial.Size = new System.Drawing.Size(528, 532);
            this.panelHistorial.TabIndex = 6;
            //
            // cabeceraHistorial
            //
            this.cabeceraHistorial.BackColor = System.Drawing.Color.Transparent;
            this.cabeceraHistorial.Controls.Add(this.tituloHistorial);
            this.cabeceraHistorial.Controls.Add(this.exportar);
            this.cabeceraHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabeceraHistorial.Location = new System.Drawing.Point(20, 16);
            this.cabeceraHistorial.Name = "cabeceraHistorial";
            this.cabeceraHistorial.Size = new System.Drawing.Size(488, 40);
            this.cabeceraHistorial.TabIndex = 0;
            //
            // tituloHistorial
            //
            this.tituloHistorial.BackColor = System.Drawing.Color.Transparent;
            this.tituloHistorial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tituloHistorial.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.tituloHistorial.Location = new System.Drawing.Point(0, 3);
            this.tituloHistorial.Name = "tituloHistorial";
            this.tituloHistorial.Size = new System.Drawing.Size(300, 34);
            this.tituloHistorial.TabIndex = 0;
            this.tituloHistorial.Text = "Historial de lecturas";
            this.tituloHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // exportar
            //
            this.exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportar.BackColor = System.Drawing.Color.FromArgb(46, 158, 107);
            this.exportar.ColorHover = System.Drawing.Color.FromArgb(37, 135, 91);
            this.exportar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.exportar.ForeColor = System.Drawing.Color.White;
            this.exportar.Location = new System.Drawing.Point(358, 3);
            this.exportar.Name = "exportar";
            this.exportar.Radio = 10;
            this.exportar.Size = new System.Drawing.Size(130, 34);
            this.exportar.TabIndex = 1;
            this.exportar.Text = "Exportar CSV";
            this.exportar.UseVisualStyleBackColor = false;
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            //
            // historial
            //
            this.historial.AllowUserToAddRows = false;
            this.historial.AllowUserToDeleteRows = false;
            this.historial.AllowUserToResizeRows = false;
            this.historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historial.BackgroundColor = System.Drawing.Color.White;
            this.historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.temperatura,
            this.humedad,
            this.indiceUv});
            this.historial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historial.Location = new System.Drawing.Point(20, 56);
            this.historial.Name = "historial";
            this.historial.ReadOnly = true;
            this.historial.RowHeadersVisible = false;
            this.historial.RowHeadersWidth = 51;
            this.historial.Size = new System.Drawing.Size(488, 456);
            this.historial.TabIndex = 1;
            //
            // Dashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1360, 800);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.menuLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1180, 720);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGRIOT - Panel principal";
            this.menuLateral.ResumeLayout(false);
            this.menuLateral.PerformLayout();
            this.pieMenu.ResumeLayout(false);
            this.pieMenu.PerformLayout();
            this.contenido.ResumeLayout(false);
            this.rejilla.ResumeLayout(false);
            this.encabezado.ResumeLayout(false);
            this.encabezado.PerformLayout();
            this.panelEstado.ResumeLayout(false);
            this.pildora.ResumeLayout(false);
            this.panelTemperatura.ResumeLayout(false);
            this.panelTemperatura.PerformLayout();
            this.insigniaTemperatura.ResumeLayout(false);
            this.panelHumedad.ResumeLayout(false);
            this.panelHumedad.PerformLayout();
            this.insigniaHumedad.ResumeLayout(false);
            this.panelUv.ResumeLayout(false);
            this.panelUv.PerformLayout();
            this.insigniaUv.ResumeLayout(false);
            this.panelVoltaje.ResumeLayout(false);
            this.panelVoltaje.PerformLayout();
            this.insigniaVoltaje.ResumeLayout(false);
            this.panelGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.panelHistorial.ResumeLayout(false);
            this.cabeceraHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historial)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel menuLateral;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label lema;
        private AGRIOT.BotonRedondeado menuDashboard;
        private AGRIOT.BotonRedondeado menuHistorial;
        private AGRIOT.BotonRedondeado menuConfiguracion;
        private System.Windows.Forms.Panel pieMenu;
        private System.Windows.Forms.Label etiquetaTopic;
        private System.Windows.Forms.Label topicInfo;
        private System.Windows.Forms.Panel contenido;
        private System.Windows.Forms.TableLayoutPanel rejilla;
        private System.Windows.Forms.Panel encabezado;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label subtituloEncabezado;
        private System.Windows.Forms.Panel panelEstado;
        private AGRIOT.PanelRedondeado pildora;
        private System.Windows.Forms.Label estadoBroker;
        private System.Windows.Forms.Label ultimaActualizacion;
        private AGRIOT.PanelRedondeado panelTemperatura;
        private AGRIOT.PanelRedondeado insigniaTemperatura;
        private System.Windows.Forms.Label simboloTemperatura;
        private System.Windows.Forms.Label textoTemperatura;
        private System.Windows.Forms.Label valorTemperatura;
        private AGRIOT.PanelRedondeado panelHumedad;
        private AGRIOT.PanelRedondeado insigniaHumedad;
        private System.Windows.Forms.Label simboloHumedad;
        private System.Windows.Forms.Label textoHumedad;
        private System.Windows.Forms.Label valorHumedad;
        private AGRIOT.PanelRedondeado panelUv;
        private AGRIOT.PanelRedondeado insigniaUv;
        private System.Windows.Forms.Label simboloUv;
        private System.Windows.Forms.Label textoUv;
        private System.Windows.Forms.Label valorUv;
        private System.Windows.Forms.Label nivelUv;
        private AGRIOT.PanelRedondeado panelVoltaje;
        private AGRIOT.PanelRedondeado insigniaVoltaje;
        private System.Windows.Forms.Label simboloVoltaje;
        private System.Windows.Forms.Label textoVoltaje;
        private System.Windows.Forms.Label valorVoltaje;
        private AGRIOT.PanelRedondeado panelGrafico;
        private System.Windows.Forms.Label tituloGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private AGRIOT.PanelRedondeado panelHistorial;
        private System.Windows.Forms.Panel cabeceraHistorial;
        private System.Windows.Forms.Label tituloHistorial;
        private AGRIOT.BotonRedondeado exportar;
        private System.Windows.Forms.DataGridView historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn humedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn indiceUv;
    }
}
