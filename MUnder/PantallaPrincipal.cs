using MUnder.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUnder
{
    public partial class PantallaPrincipal : Form
    {
        private Usuario usuarioActual;

        public PantallaPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnPlayList_Click(object sender, EventArgs e)
        {
            //  this.Hide();
            var playListForm = new PlayList(usuarioActual);
            playListForm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            Explorar ExplorarForm = new Explorar(usuarioActual);
            ExplorarForm.ShowDialog();
            //this.Close();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"      Proximamente...      ", "Canciones");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            var perfilForm = new Perfil(usuarioActual);
            perfilForm.ShowDialog();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1E1B26");
            txtBienvenida.Text = $"¡Bienvenido, {usuarioActual.Nombre}!";
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
