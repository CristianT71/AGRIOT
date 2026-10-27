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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indiceUv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuLateral = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.menuDashboard = new System.Windows.Forms.Button();
            this.menuHistorial = new System.Windows.Forms.Button();
            this.menuConfiguracion = new System.Windows.Forms.Button();
            this.contenido = new System.Windows.Forms.Panel();
            this.encabezado = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.estadoBroker = new System.Windows.Forms.Label();
            this.ultimaActualizacion = new System.Windows.Forms.Label();
            this.panelTemperatura = new System.Windows.Forms.Panel();
            this.valorTemperatura = new System.Windows.Forms.Label();
            this.textoTemperatura = new System.Windows.Forms.Label();
            this.panelHumedad = new System.Windows.Forms.Panel();
            this.valorHumedad = new System.Windows.Forms.Label();
            this.textoHumedad = new System.Windows.Forms.Label();
            this.panelUv = new System.Windows.Forms.Panel();
            this.valorUv = new System.Windows.Forms.Label();
            this.textoUv = new System.Windows.Forms.Label();
            this.nivelUv = new System.Windows.Forms.Label();
            this.panelVoltaje = new System.Windows.Forms.Panel();
            this.valorVoltaje = new System.Windows.Forms.Label();
            this.textoVoltaje = new System.Windows.Forms.Label();
            this.panelGrafico = new System.Windows.Forms.Panel();
            this.tituloGrafico = new System.Windows.Forms.Label();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.tituloHistorial = new System.Windows.Forms.Label();
            this.historial = new System.Windows.Forms.DataGridView();
            this.exportar = new System.Windows.Forms.Button();
            this.menuLateral.SuspendLayout();
            this.contenido.SuspendLayout();
            this.encabezado.SuspendLayout();
            this.panelTemperatura.SuspendLayout();
            this.panelHumedad.SuspendLayout();
            this.panelUv.SuspendLayout();
            this.panelVoltaje.SuspendLayout();
            this.panelGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.panelHistorial.SuspendLayout();
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
            this.temperatura.HeaderText = "Temperatura";
            this.temperatura.MinimumWidth = 6;
            this.temperatura.Name = "temperatura";
            this.temperatura.ReadOnly = true;
            // 
            // humedad
            // 
            this.humedad.HeaderText = "Humedad";
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
            this.menuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(74)))), ((int)(((byte)(54)))));
            this.menuLateral.Controls.Add(this.logo);
            this.menuLateral.Controls.Add(this.menuDashboard);
            this.menuLateral.Controls.Add(this.menuHistorial);
            this.menuLateral.Controls.Add(this.menuConfiguracion);
            this.menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral.Location = new System.Drawing.Point(0, 0);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(190, 760);
            this.menuLateral.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.Location = new System.Drawing.Point(28, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(130, 41);
            this.logo.TabIndex = 0;
            this.logo.Text = "AGRIOT";
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // menuDashboard
            // 
            this.menuDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(105)))), ((int)(((byte)(78)))));
            this.menuDashboard.FlatAppearance.BorderSize = 0;
            this.menuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuDashboard.ForeColor = System.Drawing.Color.White;
            this.menuDashboard.Location = new System.Drawing.Point(15, 110);
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Size = new System.Drawing.Size(160, 42);
            this.menuDashboard.TabIndex = 1;
            this.menuDashboard.Text = "Panel principal";
            this.menuDashboard.UseVisualStyleBackColor = false;
            // 
            // menuHistorial
            // 
            this.menuHistorial.BackColor = System.Drawing.Color.Transparent;
            this.menuHistorial.FlatAppearance.BorderSize = 0;
            this.menuHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuHistorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuHistorial.ForeColor = System.Drawing.Color.White;
            this.menuHistorial.Location = new System.Drawing.Point(15, 160);
            this.menuHistorial.Name = "menuHistorial";
            this.menuHistorial.Size = new System.Drawing.Size(160, 42);
            this.menuHistorial.TabIndex = 2;
            this.menuHistorial.Text = "Historial";
            this.menuHistorial.UseVisualStyleBackColor = false;
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.menuConfiguracion.FlatAppearance.BorderSize = 0;
            this.menuConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuConfiguracion.ForeColor = System.Drawing.Color.White;
            this.menuConfiguracion.Location = new System.Drawing.Point(15, 210);
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(160, 42);
            this.menuConfiguracion.TabIndex = 3;
            this.menuConfiguracion.Text = "Configuración";
            this.menuConfiguracion.UseVisualStyleBackColor = false;
            // 
            // contenido
            // 
            this.contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.contenido.Controls.Add(this.encabezado);
            this.contenido.Controls.Add(this.panelTemperatura);
            this.contenido.Controls.Add(this.panelHumedad);
            this.contenido.Controls.Add(this.panelUv);
            this.contenido.Controls.Add(this.panelVoltaje);
            this.contenido.Controls.Add(this.panelGrafico);
            this.contenido.Controls.Add(this.panelHistorial);
            this.contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenido.Location = new System.Drawing.Point(190, 0);
            this.contenido.Name = "contenido";
            this.contenido.Padding = new System.Windows.Forms.Padding(22);
            this.contenido.Size = new System.Drawing.Size(1090, 760);
            this.contenido.TabIndex = 1;
            this.contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.contenido_Paint);
            // 
            // encabezado
            // 
            this.encabezado.Controls.Add(this.titulo);
            this.encabezado.Controls.Add(this.estadoBroker);
            this.encabezado.Controls.Add(this.ultimaActualizacion);
            this.encabezado.Location = new System.Drawing.Point(22, 20);
            this.encabezado.Name = "encabezado";
            this.encabezado.Size = new System.Drawing.Size(1034, 65);
            this.encabezado.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(74)))), ((int)(((byte)(54)))));
            this.titulo.Location = new System.Drawing.Point(10, 5);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(193, 46);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Dashboard";
            // 
            // estadoBroker
            // 
            this.estadoBroker.AutoSize = true;
            this.estadoBroker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.estadoBroker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(120)))), ((int)(((byte)(25)))));
            this.estadoBroker.Location = new System.Drawing.Point(762, 5);
            this.estadoBroker.Name = "estadoBroker";
            this.estadoBroker.Size = new System.Drawing.Size(253, 23);
            this.estadoBroker.TabIndex = 1;
            this.estadoBroker.Text = "● Broker MQTT: Desconectado";
            // 
            // ultimaActualizacion
            // 
            this.ultimaActualizacion.AutoSize = true;
            this.ultimaActualizacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ultimaActualizacion.ForeColor = System.Drawing.Color.Gray;
            this.ultimaActualizacion.Location = new System.Drawing.Point(749, 31);
            this.ultimaActualizacion.Name = "ultimaActualizacion";
            this.ultimaActualizacion.Size = new System.Drawing.Size(266, 20);
            this.ultimaActualizacion.TabIndex = 2;
            this.ultimaActualizacion.Text = "Última actualización: Sin datos todavía";
            // 
            // panelTemperatura
            // 
            this.panelTemperatura.BackColor = System.Drawing.Color.White;
            this.panelTemperatura.Controls.Add(this.valorTemperatura);
            this.panelTemperatura.Controls.Add(this.textoTemperatura);
            this.panelTemperatura.Location = new System.Drawing.Point(22, 100);
            this.panelTemperatura.Name = "panelTemperatura";
            this.panelTemperatura.Size = new System.Drawing.Size(244, 105);
            this.panelTemperatura.TabIndex = 1;
            // 
            // valorTemperatura
            // 
            this.valorTemperatura.AutoSize = true;
            this.valorTemperatura.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.valorTemperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(102)))), ((int)(((byte)(53)))));
            this.valorTemperatura.Location = new System.Drawing.Point(15, 35);
            this.valorTemperatura.Name = "valorTemperatura";
            this.valorTemperatura.Size = new System.Drawing.Size(113, 57);
            this.valorTemperatura.TabIndex = 1;
            this.valorTemperatura.Text = "-- °C";
            this.valorTemperatura.Click += new System.EventHandler(this.valorTemperatura_Click);
            // 
            // textoTemperatura
            // 
            this.textoTemperatura.AutoSize = true;
            this.textoTemperatura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.textoTemperatura.ForeColor = System.Drawing.Color.Gray;
            this.textoTemperatura.Location = new System.Drawing.Point(18, 12);
            this.textoTemperatura.Name = "textoTemperatura";
            this.textoTemperatura.Size = new System.Drawing.Size(112, 23);
            this.textoTemperatura.TabIndex = 0;
            this.textoTemperatura.Text = "Temperatura";
            // 
            // panelHumedad
            // 
            this.panelHumedad.BackColor = System.Drawing.Color.White;
            this.panelHumedad.Controls.Add(this.valorHumedad);
            this.panelHumedad.Controls.Add(this.textoHumedad);
            this.panelHumedad.Location = new System.Drawing.Point(288, 100);
            this.panelHumedad.Name = "panelHumedad";
            this.panelHumedad.Size = new System.Drawing.Size(251, 105);
            this.panelHumedad.TabIndex = 2;
            // 
            // valorHumedad
            // 
            this.valorHumedad.AutoSize = true;
            this.valorHumedad.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.valorHumedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.valorHumedad.Location = new System.Drawing.Point(15, 35);
            this.valorHumedad.Name = "valorHumedad";
            this.valorHumedad.Size = new System.Drawing.Size(107, 57);
            this.valorHumedad.TabIndex = 1;
            this.valorHumedad.Text = "-- %";
            // 
            // textoHumedad
            // 
            this.textoHumedad.AutoSize = true;
            this.textoHumedad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.textoHumedad.ForeColor = System.Drawing.Color.Gray;
            this.textoHumedad.Location = new System.Drawing.Point(18, 12);
            this.textoHumedad.Name = "textoHumedad";
            this.textoHumedad.Size = new System.Drawing.Size(89, 23);
            this.textoHumedad.TabIndex = 0;
            this.textoHumedad.Text = "Humedad";
            // 
            // panelUv
            // 
            this.panelUv.BackColor = System.Drawing.Color.White;
            this.panelUv.Controls.Add(this.valorUv);
            this.panelUv.Controls.Add(this.textoUv);
            this.panelUv.Controls.Add(this.nivelUv);
            this.panelUv.Location = new System.Drawing.Point(562, 100);
            this.panelUv.Name = "panelUv";
            this.panelUv.Size = new System.Drawing.Size(240, 105);
            this.panelUv.TabIndex = 3;
            // 
            // valorUv
            // 
            this.valorUv.AutoSize = true;
            this.valorUv.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.valorUv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(91)))), ((int)(((byte)(171)))));
            this.valorUv.Location = new System.Drawing.Point(15, 35);
            this.valorUv.Name = "valorUv";
            this.valorUv.Size = new System.Drawing.Size(59, 57);
            this.valorUv.TabIndex = 1;
            this.valorUv.Text = "--";
            // 
            // textoUv
            // 
            this.textoUv.AutoSize = true;
            this.textoUv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.textoUv.ForeColor = System.Drawing.Color.Gray;
            this.textoUv.Location = new System.Drawing.Point(18, 12);
            this.textoUv.Name = "textoUv";
            this.textoUv.Size = new System.Drawing.Size(86, 23);
            this.textoUv.TabIndex = 0;
            this.textoUv.Text = "Índice UV";
            // 
            // nivelUv
            // 
            this.nivelUv.AutoSize = true;
            this.nivelUv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nivelUv.ForeColor = System.Drawing.Color.Gray;
            this.nivelUv.Location = new System.Drawing.Point(95, 57);
            this.nivelUv.Name = "nivelUv";
            this.nivelUv.Size = new System.Drawing.Size(111, 20);
            this.nivelUv.TabIndex = 2;
            this.nivelUv.Text = "Nivel: Sin datos";
            // 
            // panelVoltaje
            // 
            this.panelVoltaje.BackColor = System.Drawing.Color.White;
            this.panelVoltaje.Controls.Add(this.valorVoltaje);
            this.panelVoltaje.Controls.Add(this.textoVoltaje);
            this.panelVoltaje.Location = new System.Drawing.Point(822, 100);
            this.panelVoltaje.Name = "panelVoltaje";
            this.panelVoltaje.Size = new System.Drawing.Size(234, 105);
            this.panelVoltaje.TabIndex = 4;
            this.panelVoltaje.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVoltaje_Paint);
            // 
            // valorVoltaje
            // 
            this.valorVoltaje.AutoSize = true;
            this.valorVoltaje.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.valorVoltaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
            this.valorVoltaje.Location = new System.Drawing.Point(15, 35);
            this.valorVoltaje.Name = "valorVoltaje";
            this.valorVoltaje.Size = new System.Drawing.Size(137, 57);
            this.valorVoltaje.TabIndex = 1;
            this.valorVoltaje.Text = "-- mV";
            // 
            // textoVoltaje
            // 
            this.textoVoltaje.AutoSize = true;
            this.textoVoltaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.textoVoltaje.ForeColor = System.Drawing.Color.Gray;
            this.textoVoltaje.Location = new System.Drawing.Point(18, 12);
            this.textoVoltaje.Name = "textoVoltaje";
            this.textoVoltaje.Size = new System.Drawing.Size(178, 23);
            this.textoVoltaje.TabIndex = 0;
            this.textoVoltaje.Text = "Voltaje UV (opcional)";
            // 
            // panelGrafico
            // 
            this.panelGrafico.BackColor = System.Drawing.Color.White;
            this.panelGrafico.Controls.Add(this.tituloGrafico);
            this.panelGrafico.Controls.Add(this.grafico);
            this.panelGrafico.Location = new System.Drawing.Point(22, 225);
            this.panelGrafico.Name = "panelGrafico";
            this.panelGrafico.Size = new System.Drawing.Size(600, 485);
            this.panelGrafico.TabIndex = 5;
            // 
            // tituloGrafico
            // 
            this.tituloGrafico.AutoSize = true;
            this.tituloGrafico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tituloGrafico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tituloGrafico.Location = new System.Drawing.Point(15, 12);
            this.tituloGrafico.Name = "tituloGrafico";
            this.tituloGrafico.Size = new System.Drawing.Size(229, 25);
            this.tituloGrafico.TabIndex = 0;
            this.tituloGrafico.Text = "Temperatura y humedad";
            // 
            // grafico
            // 
            chartArea7.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea7);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend7.Name = "Legend1";
            this.grafico.Legends.Add(legend7);
            this.grafico.Location = new System.Drawing.Point(10, 38);
            this.grafico.Name = "grafico";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Temperatura";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Humedad";
            this.grafico.Series.Add(series13);
            this.grafico.Series.Add(series14);
            this.grafico.Size = new System.Drawing.Size(580, 435);
            this.grafico.TabIndex = 1;
            // 
            // panelHistorial
            // 
            this.panelHistorial.BackColor = System.Drawing.Color.White;
            this.panelHistorial.Controls.Add(this.tituloHistorial);
            this.panelHistorial.Controls.Add(this.historial);
            this.panelHistorial.Controls.Add(this.exportar);
            this.panelHistorial.Location = new System.Drawing.Point(640, 225);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(416, 485);
            this.panelHistorial.TabIndex = 6;
            // 
            // tituloHistorial
            // 
            this.tituloHistorial.AutoSize = true;
            this.tituloHistorial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tituloHistorial.Location = new System.Drawing.Point(15, 12);
            this.tituloHistorial.Name = "tituloHistorial";
            this.tituloHistorial.Size = new System.Drawing.Size(87, 25);
            this.tituloHistorial.TabIndex = 0;
            this.tituloHistorial.Text = "Historial";
            // 
            // historial
            // 
            this.historial.AllowUserToAddRows = false;
            this.historial.AllowUserToDeleteRows = false;
            this.historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historial.BackgroundColor = System.Drawing.Color.White;
            this.historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.temperatura,
            this.humedad,
            this.indiceUv});
            this.historial.Location = new System.Drawing.Point(15, 40);
            this.historial.Name = "historial";
            this.historial.ReadOnly = true;
            this.historial.RowHeadersVisible = false;
            this.historial.RowHeadersWidth = 51;
            this.historial.Size = new System.Drawing.Size(386, 390);
            this.historial.TabIndex = 1;
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(78)))));
            this.exportar.FlatAppearance.BorderSize = 0;
            this.exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportar.ForeColor = System.Drawing.Color.White;
            this.exportar.Location = new System.Drawing.Point(245, 440);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(156, 30);
            this.exportar.TabIndex = 2;
            this.exportar.Text = "Exportar historial";
            this.exportar.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.menuLateral);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGRIOT - Dashboard";
            this.menuLateral.ResumeLayout(false);
            this.menuLateral.PerformLayout();
            this.contenido.ResumeLayout(false);
            this.encabezado.ResumeLayout(false);
            this.encabezado.PerformLayout();
            this.panelTemperatura.ResumeLayout(false);
            this.panelTemperatura.PerformLayout();
            this.panelHumedad.ResumeLayout(false);
            this.panelHumedad.PerformLayout();
            this.panelUv.ResumeLayout(false);
            this.panelUv.PerformLayout();
            this.panelVoltaje.ResumeLayout(false);
            this.panelVoltaje.PerformLayout();
            this.panelGrafico.ResumeLayout(false);
            this.panelGrafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historial)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel menuLateral;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button menuDashboard;
        private System.Windows.Forms.Button menuHistorial;
        private System.Windows.Forms.Button menuConfiguracion;
        private System.Windows.Forms.Panel contenido;
        private System.Windows.Forms.Panel encabezado;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label estadoBroker;
        private System.Windows.Forms.Label ultimaActualizacion;
        private System.Windows.Forms.Panel panelTemperatura;
        private System.Windows.Forms.Label valorTemperatura;
        private System.Windows.Forms.Label textoTemperatura;
        private System.Windows.Forms.Panel panelHumedad;
        private System.Windows.Forms.Label valorHumedad;
        private System.Windows.Forms.Label textoHumedad;
        private System.Windows.Forms.Panel panelUv;
        private System.Windows.Forms.Label valorUv;
        private System.Windows.Forms.Label textoUv;
        private System.Windows.Forms.Label nivelUv;
        private System.Windows.Forms.Panel panelVoltaje;
        private System.Windows.Forms.Label valorVoltaje;
        private System.Windows.Forms.Label textoVoltaje;
        private System.Windows.Forms.Panel panelGrafico;
        private System.Windows.Forms.Label tituloGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.Label tituloHistorial;
        private System.Windows.Forms.DataGridView historial;
        private System.Windows.Forms.Button exportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn humedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn indiceUv;
    }
}
