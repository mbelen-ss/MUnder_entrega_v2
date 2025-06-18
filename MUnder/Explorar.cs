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
    public partial class Explorar : Form
    {
        private Usuario usuarioActual;

        public Explorar(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //  PantallaPrincipal PantallaPrincipalForm = new PantallaPrincipal();
            //  PantallaPrincipalForm.Show();
        }

        private void btnPlayList_Click(object sender, EventArgs e)
        {
            this.Hide();
            //   var playListForm = new PlayList();
            //   playListForm.ShowDialog();
        }

        private void Explorar_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1E1B26");
            btnPerfil.Text = $"{usuarioActual.Nombre}";
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnSocial_Click(object sender, EventArgs e)
        {

        }
    }
}
