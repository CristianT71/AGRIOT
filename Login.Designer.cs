namespace AGRIOT
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.panelMarca = new AGRIOT.PanelDegradado();
            this.logoMarca = new System.Windows.Forms.Label();
            this.lema = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.punto1 = new System.Windows.Forms.Label();
            this.punto2 = new System.Windows.Forms.Label();
            this.punto3 = new System.Windows.Forms.Label();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.subtitulo = new System.Windows.Forms.Label();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.usuario = new AGRIOT.CampoTexto();
            this.etiquetaContrasena = new System.Windows.Forms.Label();
            this.contrasena = new AGRIOT.CampoTexto();
            this.iniciarSesion = new AGRIOT.BotonRedondeado();
            this.registro = new System.Windows.Forms.LinkLabel();
            this.separador = new System.Windows.Forms.Label();
            this.accesoRostro = new AGRIOT.BotonRedondeado();
            this.accesoPose = new AGRIOT.BotonRedondeado();
            this.accesoVoz = new AGRIOT.BotonRedondeado();
            this.panelMarca.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            //
            // panelMarca
            //
            this.panelMarca.Controls.Add(this.logoMarca);
            this.panelMarca.Controls.Add(this.lema);
            this.panelMarca.Controls.Add(this.descripcion);
            this.panelMarca.Controls.Add(this.punto1);
            this.panelMarca.Controls.Add(this.punto2);
            this.panelMarca.Controls.Add(this.punto3);
            this.panelMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarca.Location = new System.Drawing.Point(0, 0);
            this.panelMarca.Name = "panelMarca";
            this.panelMarca.Size = new System.Drawing.Size(400, 640);
            this.panelMarca.TabIndex = 1;
            //
            // logoMarca
            //
            this.logoMarca.AutoSize = true;
            this.logoMarca.BackColor = System.Drawing.Color.Transparent;
            this.logoMarca.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.logoMarca.ForeColor = System.Drawing.Color.White;
            this.logoMarca.Location = new System.Drawing.Point(44, 56);
            this.logoMarca.Name = "logoMarca";
            this.logoMarca.Size = new System.Drawing.Size(180, 47);
            this.logoMarca.TabIndex = 0;
            this.logoMarca.Text = "AGRIOT";
            //
            // lema
            //
            this.lema.AutoSize = true;
            this.lema.BackColor = System.Drawing.Color.Transparent;
            this.lema.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lema.ForeColor = System.Drawing.Color.White;
            this.lema.Location = new System.Drawing.Point(46, 214);
            this.lema.Name = "lema";
            this.lema.Size = new System.Drawing.Size(300, 74);
            this.lema.TabIndex = 1;
            this.lema.Text = "Monitoreo inteligente\r\npara tu cultivo";
            //
            // descripcion
            //
            this.descripcion.BackColor = System.Drawing.Color.Transparent;
            this.descripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.descripcion.ForeColor = System.Drawing.Color.FromArgb(178, 214, 197);
            this.descripcion.Location = new System.Drawing.Point(48, 306);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(300, 52);
            this.descripcion.TabIndex = 2;
            this.descripcion.Text = "Temperatura, humedad e índice UV de tu estación, en tiempo real.";
            //
            // punto1
            //
            this.punto1.AutoSize = true;
            this.punto1.BackColor = System.Drawing.Color.Transparent;
            this.punto1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.punto1.ForeColor = System.Drawing.Color.White;
            this.punto1.Location = new System.Drawing.Point(48, 436);
            this.punto1.Name = "punto1";
            this.punto1.Size = new System.Drawing.Size(240, 20);
            this.punto1.TabIndex = 3;
            this.punto1.Text = "●   Temperatura y humedad";
            //
            // punto2
            //
            this.punto2.AutoSize = true;
            this.punto2.BackColor = System.Drawing.Color.Transparent;
            this.punto2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.punto2.ForeColor = System.Drawing.Color.White;
            this.punto2.Location = new System.Drawing.Point(48, 472);
            this.punto2.Name = "punto2";
            this.punto2.Size = new System.Drawing.Size(240, 20);
            this.punto2.TabIndex = 4;
            this.punto2.Text = "●   Índice UV y voltaje del sensor";
            //
            // punto3
            //
            this.punto3.AutoSize = true;
            this.punto3.BackColor = System.Drawing.Color.Transparent;
            this.punto3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.punto3.ForeColor = System.Drawing.Color.White;
            this.punto3.Location = new System.Drawing.Point(48, 508);
            this.punto3.Name = "punto3";
            this.punto3.Size = new System.Drawing.Size(240, 20);
            this.punto3.TabIndex = 5;
            this.punto3.Text = "●   Datos en vivo por MQTT";
            //
            // panelFormulario
            //
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.titulo);
            this.panelFormulario.Controls.Add(this.subtitulo);
            this.panelFormulario.Controls.Add(this.etiquetaUsuario);
            this.panelFormulario.Controls.Add(this.usuario);
            this.panelFormulario.Controls.Add(this.etiquetaContrasena);
            this.panelFormulario.Controls.Add(this.contrasena);
            this.panelFormulario.Controls.Add(this.iniciarSesion);
            this.panelFormulario.Controls.Add(this.registro);
            this.panelFormulario.Controls.Add(this.separador);
            this.panelFormulario.Controls.Add(this.accesoRostro);
            this.panelFormulario.Controls.Add(this.accesoPose);
            this.panelFormulario.Controls.Add(this.accesoVoz);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(400, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(500, 640);
            this.panelFormulario.TabIndex = 0;
            //
            // titulo
            //
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.titulo.Location = new System.Drawing.Point(76, 150);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(300, 41);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Bienvenido de nuevo";
            //
            // subtitulo
            //
            this.subtitulo.AutoSize = true;
            this.subtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.subtitulo.Location = new System.Drawing.Point(80, 198);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(220, 19);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Ingresa tus datos para continuar";
            //
            // etiquetaUsuario
            //
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.etiquetaUsuario.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.etiquetaUsuario.Location = new System.Drawing.Point(80, 252);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(55, 17);
            this.etiquetaUsuario.TabIndex = 2;
            this.etiquetaUsuario.Text = "Usuario";
            //
            // usuario
            //
            this.usuario.Location = new System.Drawing.Point(80, 276);
            this.usuario.Name = "usuario";
            this.usuario.Placeholder = "Ingresa tu usuario";
            this.usuario.Size = new System.Drawing.Size(340, 46);
            this.usuario.TabIndex = 3;
            //
            // etiquetaContrasena
            //
            this.etiquetaContrasena.AutoSize = true;
            this.etiquetaContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.etiquetaContrasena.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.etiquetaContrasena.Location = new System.Drawing.Point(80, 338);
            this.etiquetaContrasena.Name = "etiquetaContrasena";
            this.etiquetaContrasena.Size = new System.Drawing.Size(78, 17);
            this.etiquetaContrasena.TabIndex = 4;
            this.etiquetaContrasena.Text = "Contraseña";
            //
            // contrasena
            //
            this.contrasena.Location = new System.Drawing.Point(80, 362);
            this.contrasena.Name = "contrasena";
            this.contrasena.Placeholder = "Ingresa tu contraseña";
            this.contrasena.Size = new System.Drawing.Size(340, 46);
            this.contrasena.TabIndex = 5;
            this.contrasena.UseSystemPasswordChar = true;
            //
            // iniciarSesion
            //
            this.iniciarSesion.BackColor = System.Drawing.Color.FromArgb(46, 158, 107);
            this.iniciarSesion.ColorHover = System.Drawing.Color.FromArgb(37, 135, 91);
            this.iniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.iniciarSesion.ForeColor = System.Drawing.Color.White;
            this.iniciarSesion.Location = new System.Drawing.Point(80, 438);
            this.iniciarSesion.Name = "iniciarSesion";
            this.iniciarSesion.Size = new System.Drawing.Size(340, 50);
            this.iniciarSesion.TabIndex = 6;
            this.iniciarSesion.Text = "Iniciar sesión";
            this.iniciarSesion.UseVisualStyleBackColor = false;
            this.iniciarSesion.Click += new System.EventHandler(this.iniciarSesion_Click);
            //
            // registro
            //
            this.registro.ActiveLinkColor = System.Drawing.Color.FromArgb(37, 135, 91);
            this.registro.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.registro.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.registro.LinkArea = new System.Windows.Forms.LinkArea(19, 16);
            this.registro.LinkColor = System.Drawing.Color.FromArgb(37, 135, 91);
            this.registro.Location = new System.Drawing.Point(80, 592);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(340, 24);
            this.registro.TabIndex = 7;
            this.registro.TabStop = true;
            this.registro.Text = "¿No tienes cuenta? Crear una cuenta";
            this.registro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registro_LinkClicked);
            //
            // separador
            //
            this.separador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.separador.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.separador.Location = new System.Drawing.Point(80, 506);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(340, 20);
            this.separador.TabIndex = 8;
            this.separador.Text = "o ingresa con";
            this.separador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // accesoRostro
            //
            this.accesoRostro.BackColor = System.Drawing.Color.FromArgb(236, 243, 239);
            this.accesoRostro.ColorHover = System.Drawing.Color.FromArgb(222, 233, 227);
            this.accesoRostro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.accesoRostro.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.accesoRostro.Location = new System.Drawing.Point(80, 534);
            this.accesoRostro.Name = "accesoRostro";
            this.accesoRostro.Size = new System.Drawing.Size(108, 44);
            this.accesoRostro.TabIndex = 9;
            this.accesoRostro.Text = "Rostro";
            this.accesoRostro.UseVisualStyleBackColor = false;
            this.accesoRostro.Click += new System.EventHandler(this.accesoRostro_Click);
            //
            // accesoPose
            //
            this.accesoPose.BackColor = System.Drawing.Color.FromArgb(236, 243, 239);
            this.accesoPose.ColorHover = System.Drawing.Color.FromArgb(222, 233, 227);
            this.accesoPose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.accesoPose.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.accesoPose.Location = new System.Drawing.Point(196, 534);
            this.accesoPose.Name = "accesoPose";
            this.accesoPose.Size = new System.Drawing.Size(108, 44);
            this.accesoPose.TabIndex = 10;
            this.accesoPose.Text = "Pose";
            this.accesoPose.UseVisualStyleBackColor = false;
            this.accesoPose.Click += new System.EventHandler(this.accesoPose_Click);
            //
            // accesoVoz
            //
            this.accesoVoz.BackColor = System.Drawing.Color.FromArgb(236, 243, 239);
            this.accesoVoz.ColorHover = System.Drawing.Color.FromArgb(222, 233, 227);
            this.accesoVoz.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.accesoVoz.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.accesoVoz.Location = new System.Drawing.Point(312, 534);
            this.accesoVoz.Name = "accesoVoz";
            this.accesoVoz.Size = new System.Drawing.Size(108, 44);
            this.accesoVoz.TabIndex = 11;
            this.accesoVoz.Text = "Voz";
            this.accesoVoz.UseVisualStyleBackColor = false;
            this.accesoVoz.Click += new System.EventHandler(this.accesoVoz_Click);
            //
            // Login
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelMarca);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGRIOT - Iniciar sesión";
            this.panelMarca.ResumeLayout(false);
            this.panelMarca.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AGRIOT.PanelDegradado panelMarca;
        private System.Windows.Forms.Label logoMarca;
        private System.Windows.Forms.Label lema;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label punto1;
        private System.Windows.Forms.Label punto2;
        private System.Windows.Forms.Label punto3;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label subtitulo;
        private System.Windows.Forms.Label etiquetaUsuario;
        private AGRIOT.CampoTexto usuario;
        private System.Windows.Forms.Label etiquetaContrasena;
        private AGRIOT.CampoTexto contrasena;
        private AGRIOT.BotonRedondeado iniciarSesion;
        private System.Windows.Forms.LinkLabel registro;
        private System.Windows.Forms.Label separador;
        private AGRIOT.BotonRedondeado accesoRostro;
        private AGRIOT.BotonRedondeado accesoPose;
        private AGRIOT.BotonRedondeado accesoVoz;
    }
}
