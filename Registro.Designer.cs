namespace AGRIOT
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contenedor = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.subtitulo = new System.Windows.Forms.Label();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.etiquetaCorreo = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.etiquetaContrasena = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.etiquetaConfirmar = new System.Windows.Forms.Label();
            this.confirmarContrasena = new System.Windows.Forms.TextBox();
            this.registrarse = new System.Windows.Forms.Button();
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
            this.contenedor.Controls.Add(this.etiquetaCorreo);
            this.contenedor.Controls.Add(this.correo);
            this.contenedor.Controls.Add(this.etiquetaContrasena);
            this.contenedor.Controls.Add(this.contrasena);
            this.contenedor.Controls.Add(this.etiquetaConfirmar);
            this.contenedor.Controls.Add(this.confirmarContrasena);
            this.contenedor.Controls.Add(this.registrarse);
            this.contenedor.Location = new System.Drawing.Point(180, 20);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(440, 410);
            this.contenedor.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(74)))), ((int)(((byte)(54)))));
            this.titulo.Location = new System.Drawing.Point(156, 20);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(162, 41);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Registrate";
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.subtitulo.Location = new System.Drawing.Point(117, 61);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(200, 20);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Crea tu cuenta para empezar";
            // 
            // etiquetaUsuario
            // 
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.etiquetaUsuario.Location = new System.Drawing.Point(58, 94);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(63, 20);
            this.etiquetaUsuario.TabIndex = 2;
            this.etiquetaUsuario.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usuario.Location = new System.Drawing.Point(61, 115);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(318, 30);
            this.usuario.TabIndex = 3;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // etiquetaCorreo
            // 
            this.etiquetaCorreo.AutoSize = true;
            this.etiquetaCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.etiquetaCorreo.Location = new System.Drawing.Point(58, 151);
            this.etiquetaCorreo.Name = "etiquetaCorreo";
            this.etiquetaCorreo.Size = new System.Drawing.Size(137, 20);
            this.etiquetaCorreo.TabIndex = 4;
            this.etiquetaCorreo.Text = "Correo electrónico";
            // 
            // correo
            // 
            this.correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.correo.Location = new System.Drawing.Point(61, 172);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(318, 30);
            this.correo.TabIndex = 5;
            this.correo.TextChanged += new System.EventHandler(this.correo_TextChanged);
            // 
            // etiquetaContrasena
            // 
            this.etiquetaContrasena.AutoSize = true;
            this.etiquetaContrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.etiquetaContrasena.Location = new System.Drawing.Point(58, 208);
            this.etiquetaContrasena.Name = "etiquetaContrasena";
            this.etiquetaContrasena.Size = new System.Drawing.Size(88, 20);
            this.etiquetaContrasena.TabIndex = 6;
            this.etiquetaContrasena.Text = "Contraseña";
            // 
            // contrasena
            // 
            this.contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contrasena.Location = new System.Drawing.Point(61, 229);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(318, 30);
            this.contrasena.TabIndex = 7;
            this.contrasena.UseSystemPasswordChar = true;
            this.contrasena.TextChanged += new System.EventHandler(this.contrasena_TextChanged);
            // 
            // etiquetaConfirmar
            // 
            this.etiquetaConfirmar.AutoSize = true;
            this.etiquetaConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.etiquetaConfirmar.Location = new System.Drawing.Point(58, 265);
            this.etiquetaConfirmar.Name = "etiquetaConfirmar";
            this.etiquetaConfirmar.Size = new System.Drawing.Size(161, 20);
            this.etiquetaConfirmar.TabIndex = 8;
            this.etiquetaConfirmar.Text = "Confirmar contraseña";
            // 
            // confirmarContrasena
            // 
            this.confirmarContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.confirmarContrasena.Location = new System.Drawing.Point(61, 286);
            this.confirmarContrasena.Name = "confirmarContrasena";
            this.confirmarContrasena.Size = new System.Drawing.Size(318, 30);
            this.confirmarContrasena.TabIndex = 9;
            this.confirmarContrasena.UseSystemPasswordChar = true;
            this.confirmarContrasena.TextChanged += new System.EventHandler(this.confirmarContrasena_TextChanged);
            // 
            // registrarse
            // 
            this.registrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(78)))));
            this.registrarse.FlatAppearance.BorderSize = 0;
            this.registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.registrarse.ForeColor = System.Drawing.Color.White;
            this.registrarse.Location = new System.Drawing.Point(61, 338);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(318, 38);
            this.registrarse.TabIndex = 10;
            this.registrarse.Text = "Registrarse";
            this.registrarse.UseVisualStyleBackColor = false;
            this.registrarse.Click += new System.EventHandler(this.registrarse_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
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
        private System.Windows.Forms.Label etiquetaCorreo;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label etiquetaContrasena;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Label etiquetaConfirmar;
        private System.Windows.Forms.TextBox confirmarContrasena;
        private System.Windows.Forms.Button registrarse;
    }
}