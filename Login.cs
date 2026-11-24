using System.Windows.Forms;

namespace AGRIOT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AcceptButton = iniciarSesion;
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

            AbrirDashboard("Cristian");
        }

        private void AbrirDashboard(string nombre)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.UsuarioActual = nombre;
            dashboard.FormClosed += (s, args) => Application.Exit();
            dashboard.Show();
            this.Hide();
        }

        private void IniciarConModelo(ModoBiometrico modo)
        {
            using (var ventana = new LoginBiometrico(modo))
            {
                if (ventana.ShowDialog(this) == DialogResult.OK)
                    AbrirDashboard(ventana.UsuarioIdentificado);
            }
        }

        private void accesoRostro_Click(object sender, System.EventArgs e) { IniciarConModelo(ModoBiometrico.Rostro); }
        private void accesoPose_Click(object sender, System.EventArgs e) { IniciarConModelo(ModoBiometrico.Pose); }
        private void accesoVoz_Click(object sender, System.EventArgs e) { IniciarConModelo(ModoBiometrico.Voz); }

        private void registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro pantallaRegistro = new Registro();
            pantallaRegistro.FormClosed += (s, args) => this.Show();
            pantallaRegistro.Show();
            this.Hide();
        }
    }
}
