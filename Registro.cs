using System.Windows.Forms;

namespace AGRIOT
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            AcceptButton = registrarse;
        }

        private void registrarse_Click(object sender, System.EventArgs e)
        {
            string error = null;
            if (usuario.Text.Trim().Length == 0 || correo.Text.Trim().Length == 0 ||
                contrasena.Text.Length == 0 || confirmarContrasena.Text.Length == 0)
                error = "Completa todos los campos.";
            else if (!correo.Text.Contains("@") || !correo.Text.Contains("."))
                error = "Ingresa un correo electrónico válido.";
            else if (contrasena.Text.Length < 8)
                error = "La contraseña debe tener al menos 8 caracteres.";
            else if (contrasena.Text != confirmarContrasena.Text)
                error = "Las contraseñas no coinciden.";

            if (error != null)
            {
                MessageBox.Show(error, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aún no hay base de usuarios: el registro es de demostración.
            MessageBox.Show("Cuenta creada (modo demostración). Ya puedes iniciar sesión.", "Registro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        // Al cerrarse, Login vuelve a mostrarse (ver Login.registro_LinkClicked).
        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
