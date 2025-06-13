using Microsoft.EntityFrameworkCore;
using MUnder.Data;
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
    public partial class NuevaPlaylist : Form
    {
        private Usuario usuarioActual;

        public NuevaPlaylist(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        // Este método puede usarse luego para acceder al ID
        public int ObtenerIdUsuario() => usuarioActual.Id;

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NuevaPlaylist_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1E1B26");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            PlayList playListForm = new PlayList(usuarioActual);
            playListForm.Show();
            this.Close();
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            Explorar ExplorarForm = new Explorar();
            ExplorarForm.Show();
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePlaylist.Text))
            {
                MessageBox.Show("Ingrese un nombre para la playlist.");
                return;
            }

            string nombrePlaylist = txtNombrePlaylist.Text;

            using (var context = new AppDbContext())
            {
                try
                {
                    var nuevaPlaylist = new Playlist
                    {
                        Nombre = nombrePlaylist,
                        UsuarioId = usuarioActual.Id,
                        //Propietario = usuarioActual



                    };

                    context.Playlists.Add(nuevaPlaylist);
                    context.SaveChanges();

                    MessageBox.Show("Playlist creada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
