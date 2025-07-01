using MUnder.Services;
using System.Net.Mail;
using System.Net;

namespace MUnder
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string GenerarCodigoOTP()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }

        private void EnviarCodigoPorEmail(string destinoEmail, string codigo)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("munder.music@gmail.com");
                mensaje.To.Add(destinoEmail);
                mensaje.Subject = "Código de verificación - MUnder";
                mensaje.Body = $"Tu código de verificación es: {codigo}";

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential("munder.music@gmail.com", "hsfynuicfkhdkuef");


                cliente.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar email: {ex.Message}", "Error de Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            if (usuario != null)
            {
                // Generar código OTP
                string codigoOTP = GenerarCodigoOTP();

                // Enviar código OTP al email
                EnviarCodigoPorEmail(usuario.Correo, codigoOTP);

                // Mostrar formulario de verificación, pasando el código OTP
                var formVerificacion = new Verificacion(codigoOTP);
                var resultado = formVerificacion.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    MessageBox.Show($"      ¡Bienvenido {usuario.Nombre}!      ", "Login exitoso");

                    // Abrir pantalla principal solo si pasa la verificación
                    var mainForm = new PantallaPrincipal(usuario);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("      Verificación fallida o cancelada      ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("      Correo o contraseña incorrectos      ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
