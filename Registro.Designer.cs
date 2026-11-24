namespace AGRIOT
{
    partial class Registro
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
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.subtitulo = new System.Windows.Forms.Label();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.usuario = new AGRIOT.CampoTexto();
            this.etiquetaCorreo = new System.Windows.Forms.Label();
            this.correo = new AGRIOT.CampoTexto();
            this.etiquetaContrasena = new System.Windows.Forms.Label();
            this.contrasena = new AGRIOT.CampoTexto();
            this.etiquetaConfirmar = new System.Windows.Forms.Label();
            this.confirmarContrasena = new AGRIOT.CampoTexto();
            this.registrarse = new AGRIOT.BotonRedondeado();
            this.irLogin = new System.Windows.Forms.LinkLabel();
            this.panelMarca.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            //
            // panelMarca
            //
            this.panelMarca.Controls.Add(this.logoMarca);
            this.panelMarca.Controls.Add(this.lema);
            this.panelMarca.Controls.Add(this.descripcion);
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
            this.lema.Text = "Empieza a cuidar\r\ntu cultivo con datos";
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
            this.descripcion.Text = "Crea tu cuenta y conecta tu estación para ver las lecturas al instante.";
            //
            // panelFormulario
            //
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.titulo);
            this.panelFormulario.Controls.Add(this.subtitulo);
            this.panelFormulario.Controls.Add(this.etiquetaUsuario);
            this.panelFormulario.Controls.Add(this.usuario);
            this.panelFormulario.Controls.Add(this.etiquetaCorreo);
            this.panelFormulario.Controls.Add(this.correo);
            this.panelFormulario.Controls.Add(this.etiquetaContrasena);
            this.panelFormulario.Controls.Add(this.contrasena);
            this.panelFormulario.Controls.Add(this.etiquetaConfirmar);
            this.panelFormulario.Controls.Add(this.confirmarContrasena);
            this.panelFormulario.Controls.Add(this.registrarse);
            this.panelFormulario.Controls.Add(this.irLogin);
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
            this.titulo.Location = new System.Drawing.Point(76, 44);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(250, 41);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Crea tu cuenta";
            //
            // subtitulo
            //
            this.subtitulo.AutoSize = true;
            this.subtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.subtitulo.Location = new System.Drawing.Point(80, 92);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(200, 19);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Completa los datos para empezar";
            //
            // etiquetaUsuario
            //
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.etiquetaUsuario.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.etiquetaUsuario.Location = new System.Drawing.Point(80, 142);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(55, 17);
            this.etiquetaUsuario.TabIndex = 2;
            this.etiquetaUsuario.Text = "Usuario";
            //
            // usuario
            //
            this.usuario.Location = new System.Drawing.Point(80, 166);
            this.usuario.Name = "usuario";
            this.usuario.Placeholder = "Elige un nombre de usuario";
            this.usuario.Size = new System.Drawing.Size(340, 46);
            this.usuario.TabIndex = 3;
            //
            // etiquetaCorreo
            //
            this.etiquetaCorreo.AutoSize = true;
            this.etiquetaCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.etiquetaCorreo.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.etiquetaCorreo.Location = new System.Drawing.Point(80, 226);
            this.etiquetaCorreo.Name = "etiquetaCorreo";
            this.etiquetaCorreo.Size = new System.Drawing.Size(119, 17);
            this.etiquetaCorreo.TabIndex = 4;
            this.etiquetaCorreo.Text = "Correo electrónico";
            //
            // correo
            //
            this.correo.Location = new System.Drawing.Point(80, 250);
            this.correo.Name = "correo";
            this.correo.Placeholder = "tucorreo@ejemplo.com";
            this.correo.Size = new System.Drawing.Size(340, 46);
            this.correo.TabIndex = 5;
            //
            // etiquetaContrasena
            //
            this.etiquetaContrasena.AutoSize = true;
            this.etiquetaContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.etiquetaContrasena.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.etiquetaContrasena.Location = new System.Drawing.Point(80, 310);
            this.etiquetaContrasena.Name = "etiquetaContrasena";
            this.etiquetaContrasena.Size = new System.Drawing.Size(78, 17);
            this.etiquetaContrasena.TabIndex = 6;
            this.etiquetaContrasena.Text = "Contraseña";
            //
            // contrasena
            //
            this.contrasena.Location = new System.Drawing.Point(80, 334);
            this.contrasena.Name = "contrasena";
            this.contrasena.Placeholder = "Mínimo 8 caracteres";
            this.contrasena.Size = new System.Drawing.Size(340, 46);
            this.contrasena.TabIndex = 7;
            this.contrasena.UseSystemPasswordChar = true;
            //
            // etiquetaConfirmar
            //
            this.etiquetaConfirmar.AutoSize = true;
            this.etiquetaConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.etiquetaConfirmar.ForeColor = System.Drawing.Color.FromArgb(31, 45, 39);
            this.etiquetaConfirmar.Location = new System.Drawing.Point(80, 394);
            this.etiquetaConfirmar.Name = "etiquetaConfirmar";
            this.etiquetaConfirmar.Size = new System.Drawing.Size(130, 17);
            this.etiquetaConfirmar.TabIndex = 8;
            this.etiquetaConfirmar.Text = "Confirmar contraseña";
            //
            // confirmarContrasena
            //
            this.confirmarContrasena.Location = new System.Drawing.Point(80, 418);
            this.confirmarContrasena.Name = "confirmarContrasena";
            this.confirmarContrasena.Placeholder = "Repite tu contraseña";
            this.confirmarContrasena.Size = new System.Drawing.Size(340, 46);
            this.confirmarContrasena.TabIndex = 9;
            this.confirmarContrasena.UseSystemPasswordChar = true;
            //
            // registrarse
            //
            this.registrarse.BackColor = System.Drawing.Color.FromArgb(46, 158, 107);
            this.registrarse.ColorHover = System.Drawing.Color.FromArgb(37, 135, 91);
            this.registrarse.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.registrarse.ForeColor = System.Drawing.Color.White;
            this.registrarse.Location = new System.Drawing.Point(80, 492);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(340, 50);
            this.registrarse.TabIndex = 10;
            this.registrarse.Text = "Registrarse";
            this.registrarse.UseVisualStyleBackColor = false;
            this.registrarse.Click += new System.EventHandler(this.registrarse_Click);
            //
            // irLogin
            //
            this.irLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(37, 135, 91);
            this.irLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.irLogin.ForeColor = System.Drawing.Color.FromArgb(107, 124, 116);
            this.irLogin.LinkArea = new System.Windows.Forms.LinkArea(19, 14);
            this.irLogin.LinkColor = System.Drawing.Color.FromArgb(37, 135, 91);
            this.irLogin.Location = new System.Drawing.Point(80, 566);
            this.irLogin.Name = "irLogin";
            this.irLogin.Size = new System.Drawing.Size(340, 24);
            this.irLogin.TabIndex = 11;
            this.irLogin.TabStop = true;
            this.irLogin.Text = "¿Ya tienes cuenta? Iniciar sesión";
            this.irLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.irLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            //
            // Registro
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
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGRIOT - Registro";
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
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label subtitulo;
        private System.Windows.Forms.Label etiquetaUsuario;
        private AGRIOT.CampoTexto usuario;
        private System.Windows.Forms.Label etiquetaCorreo;
        private AGRIOT.CampoTexto correo;
        private System.Windows.Forms.Label etiquetaContrasena;
        private AGRIOT.CampoTexto contrasena;
        private System.Windows.Forms.Label etiquetaConfirmar;
        private AGRIOT.CampoTexto confirmarContrasena;
        private AGRIOT.BotonRedondeado registrarse;
        private System.Windows.Forms.LinkLabel irLogin;
    }
}
