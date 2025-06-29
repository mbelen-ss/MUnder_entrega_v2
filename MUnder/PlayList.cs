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
using MUnder.Data;

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
            txtPerfil.Text = $"{usuarioActual.Nombre}, estas son tus PlayList";

            CargarPlaylistsPersonalizadas();
        }
        //funcionalidad de los botones - Abrir Vistas de Canciones por Género
        private void AbrirVistaCanciones(string genero)
        {
            var servicio = new CancionService();
            var canciones = servicio.ObtenerPorGenero(genero);

            var vista = new VistaCanciones(canciones, usuarioActual);
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

        private void btnIndieFolkArg_Click_1(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Indie Folk Argentino");
        }

        private void btnHipHopUnder_Click_1(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Hip Hop Underground");
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

        private void txtPerfil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BotonPlaylist_Click(object sender, EventArgs e)
        {
            var boton = sender as Button;
            if (boton?.Tag is Playlist playlist)
            {
                AbrirVistaCancionesDePlaylist(playlist);
            }
        }

        private void AbrirVistaCancionesDePlaylist(Playlist playlist)
        {
            var servicio = new CancionService();
            var canciones = servicio.ObtenerPorPlaylistId(playlist.Id); // Este método lo tenés que tener en tu servicio
            var vista = new VistaCanciones(canciones, usuarioActual);
            vista.ShowDialog();
        }

        private void CargarPlaylistsPersonalizadas()
        {
            using (var context = new MUnder.Data.AppDbContext())
            {
                var playlists = context.Playlists
                    .Where(p => p.UsuarioId == usuarioActual.Id && p.Id >= 5)
                    .OrderBy(p => p.Id)
                    .Take(4)
                    .ToList();

                var botones = new List<Button> { button1, button2, button3, button4 };

                for (int i = 0; i < botones.Count; i++)
                {
                    var btn = botones[i];
                    btn.Click -= BotonPlaylist_Click; // eliminamos cualquier handler viejo
                    btn.Tag = null;
                    btn.Enabled = false;
                    btn.Text = "+";
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.White;

                    if (i < playlists.Count)
                    {
                        var playlist = playlists[i];
                        btn.Text = playlist.Nombre;
                        btn.Enabled = true;
                        btn.BackColor = Color.Transparent;
                        btn.Tag = playlist;
                        btn.Click += BotonPlaylist_Click;
                    }
                }
            }

        }
    }
}
