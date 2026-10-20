namespace AGRIOT
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.contenedor = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.subtitulo = new System.Windows.Forms.Label();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.etiquetaContrasena = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.iniciarSesion = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.LinkLabel();
            this.contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Controls.Add(this.titulo);
            this.contenedor.Controls.Add(this.subtitulo);
            this.contenedor.Controls.Add(this.etiquetaUsuario);
            this.contenedor.Controls.Add(this.usuario);
            this.contenedor.Controls.Add(this.etiquetaContrasena);
            this.contenedor.Controls.Add(this.contrasena);
            this.contenedor.Controls.Add(this.iniciarSesion);
            this.contenedor.Controls.Add(this.registro);
            this.contenedor.Location = new System.Drawing.Point(180, 35);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(440, 380);
            this.contenedor.TabIndex = 0;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(74)))), ((int)(((byte)(54)))));
            this.titulo.Location = new System.Drawing.Point(145, 28);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(201, 41);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Iniciar sesión";
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.subtitulo.Location = new System.Drawing.Point(116, 70);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(221, 20);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Ingresa tus datos para continuar";
            // 
            // etiquetaUsuario
            // 
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.etiquetaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.etiquetaUsuario.Location = new System.Drawing.Point(58, 116);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(63, 20);
            this.etiquetaUsuario.TabIndex = 2;
            this.etiquetaUsuario.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usuario.Location = new System.Drawing.Point(61, 137);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(318, 30);
            this.usuario.TabIndex = 3;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // etiquetaContrasena
            // 
            this.etiquetaContrasena.AutoSize = true;
            this.etiquetaContrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.etiquetaContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.etiquetaContrasena.Location = new System.Drawing.Point(58, 177);
            this.etiquetaContrasena.Name = "etiquetaContrasena";
            this.etiquetaContrasena.Size = new System.Drawing.Size(88, 20);
            this.etiquetaContrasena.TabIndex = 4;
            this.etiquetaContrasena.Text = "Contraseña";
            // 
            // contrasena
            // 
            this.contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contrasena.Location = new System.Drawing.Point(61, 198);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(318, 30);
            this.contrasena.TabIndex = 5;
            this.contrasena.UseSystemPasswordChar = true;
            this.contrasena.TextChanged += new System.EventHandler(this.contrasena_TextChanged);
            // 
            // iniciarSesion
            // 
            this.iniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(78)))));
            this.iniciarSesion.FlatAppearance.BorderSize = 0;
            this.iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iniciarSesion.ForeColor = System.Drawing.Color.White;
            this.iniciarSesion.Location = new System.Drawing.Point(61, 247);
            this.iniciarSesion.Name = "iniciarSesion";
            this.iniciarSesion.Size = new System.Drawing.Size(318, 38);
            this.iniciarSesion.TabIndex = 6;
            this.iniciarSesion.Text = "Iniciar sesión";
            this.iniciarSesion.UseVisualStyleBackColor = false;
            this.iniciarSesion.Click += new System.EventHandler(this.iniciarSesion_Click);
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(78)))));
            this.registro.Location = new System.Drawing.Point(146, 310);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(163, 20);
            this.registro.TabIndex = 7;
            this.registro.TabStop = true;
            this.registro.Text = "Crear una cuenta nueva";
            this.registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label subtitulo;
        private System.Windows.Forms.Label etiquetaUsuario;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label etiquetaContrasena;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Button iniciarSesion;
        private System.Windows.Forms.LinkLabel registro;
    }
}
