using MUnder.Entidades;
using MUnder.Services;
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
    public partial class PlayList : Form
    {
        private Usuario usuarioActual;
        public PlayList(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void PlayList_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1E1B26");
            btnPerfil.Text = $"{usuarioActual.Nombre}";
        }
        //funcionalidad de los botones - Abrir Vistas de Canciones por Género
        private void AbrirVistaCanciones(string genero)
        {
            var servicio = new CancionService();
            var canciones = servicio.ObtenerPorGenero(genero);

            var vista = new VistaCanciones(canciones);
            vista.ShowDialog();
        }
        private void btnRockAlter2024_Click(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Rock Alternativo 2024");
        }

        private void btnElectroExperimental_Click(object sender, EventArgs e)
        {
            AbrirVistaCanciones("ElectrÃ³nica Experimental");
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"      Debe ir a la pantalla princical para acceder      ", "Musica");
        }

        private void btnIndieFolkArg_Click_1(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Indie Folk Argentino");
        }

        private void btnHipHopUnder_Click_1(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Hip Hop Underground");
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón 'Social' clickeado");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnCreaPlayList_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevaPlaylist NuevaPlaylistForm = new NuevaPlaylist(usuarioActual);
            NuevaPlaylistForm.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //PantallaPrincipal PantallaPrincipalForm = new PantallaPrincipal();
            // PantallaPrincipalForm.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"      Proximamente...      ", "Mensajes");
        }

        private void btnSocial_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"      Proximamente...      ", "Social");
        }
    }
}
