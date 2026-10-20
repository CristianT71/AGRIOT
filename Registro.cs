using System.Windows.Forms;

namespace AGRIOT
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void usuario_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void contrasena_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void confirmarContrasena_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void registrarse_Click(object sender, System.EventArgs e)
        {
            
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login Registro = new Login();
            Registro.Show();
            this.Hide();
        }
    }
}
