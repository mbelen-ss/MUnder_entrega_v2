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
    public partial class VistaCanciones : Form
    {
        private Usuario usuarioActual;

        public VistaCanciones(List<Cancion> canciones,Usuario usuario)
        {
            InitializeComponent();

            ListaCanciones.DataSource = canciones;
            ListaCanciones.AutoGenerateColumns = true;
            usuarioActual = usuario;

        }

        private void VistaCanciones_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1E1B26");
            txtPerfil.Text = $"{usuarioActual.Nombre}, estas son tus canciones";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //   PlayList playListForm = new PlayList();
            // playListForm.Show();
            this.Close();
        }
    }
}
