using MUnder.Services;

namespace MUnder
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registroForm = new Registro();
            registroForm.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string correo = txtUsuario.Text.Trim();
            string contrasena = txtClave.Text;

            var servicio = new UsuarioService();
            var usuario = servicio.Login(correo, contrasena);
            //Common.UsuarioLogin.Id = usuario.Id;
            //Common.UsuarioLogin.Nombre = usuario.Nombre;

            if (usuario != null)
            {
                MessageBox.Show($"      �Bienvenido {usuario.Nombre}!      ", "Login exitoso");

                // Ac� pod�s abrir el men� principal o dashboard:
                //var mainForm = new NuevaPlaylist(usuario); // suponiendo que exista
                var mainForm = new PantallaPrincipal(usuario);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("      Correo o contrase�a incorrectos      ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1E1B26");

        }
    }
}
