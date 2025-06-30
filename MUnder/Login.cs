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