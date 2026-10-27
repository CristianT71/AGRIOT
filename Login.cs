using System.Windows.Forms;

namespace AGRIOT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, System.EventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuario_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void contrasena_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void iniciarSesion_Click(object sender, System.EventArgs e)
        {
            // Credenciales fijas mientras no exista una base de usuarios.
            const string UsuarioValido = "Cristian";
            const string ContrasenaValida = "Cristian12@";

            bool ok = string.Equals(usuario.Text.Trim(), UsuarioValido, System.StringComparison.OrdinalIgnoreCase)
                      && contrasena.Text == ContrasenaValida;
            if (!ok)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Iniciar sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contrasena.Clear();
                contrasena.Focus();
                return;
            }

            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => Application.Exit();
            dashboard.Show();
            this.Hide();
        }

        private void registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro Login = new Registro();
            Login.Show();
            this.Hide();
        }
    }
}
