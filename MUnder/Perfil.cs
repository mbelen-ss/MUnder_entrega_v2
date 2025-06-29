using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MUnder.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MUnder
{
    public partial class Perfil : Form
    {
        private Usuario usuarioActual;

        public Perfil(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1E1B26");
            lblTitulo.ForeColor = Color.White;
            lblNombreUsuario.Text = usuarioActual.Nombre;
            lblEmailUsuario.Text = usuarioActual.Correo;
            // Si tienes más datos en Usuario, asignalos aquí para mostrar
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Aquí podés implementar lógica para cerrar sesión,
            // por ejemplo, volver a la pantalla de login
            this.Close();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            // Si querés, abrir un formulario para editar perfil
            MessageBox.Show("Función editar perfil no implementada aún.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}