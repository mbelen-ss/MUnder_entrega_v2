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
using MUnder.Data;

namespace MUnder
{
    public partial class Explorar : Form
    {
        private Usuario usuarioActual;
        private List<Cancion> canciones;

        public Explorar(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            button1.Click += btnCancion_Click;
            button2.Click += btnCancion_Click;
            button3.Click += btnCancion_Click;
            button4.Click += btnCancion_Click;
            button5.Click += btnCancion_Click;
            button6.Click += btnCancion_Click;
            button7.Click += btnCancion_Click;
            button8.Click += btnCancion_Click;
            button9.Click += btnCancion_Click;
            button10.Click += btnCancion_Click;
            button11.Click += btnCancion_Click;
            button12.Click += btnCancion_Click;
            button13.Click += btnCancion_Click;
            button14.Click += btnCancion_Click;
            button15.Click += btnCancion_Click;
            button16.Click += btnCancion_Click;
            button17.Click += btnCancion_Click;
            button18.Click += btnCancion_Click;
            button19.Click += btnCancion_Click;
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
            txtPerfil.Text = $"{usuarioActual.Nombre}, elegí tu vibra musical";

            CargarCancionesDesdeBD();
            MostrarCancionesEnBotones();

        }

        private void CargarCancionesDesdeBD()
        {
            try
            {
                using (var contexto = new AppDbContext())
                {
                    canciones = contexto.Canciones
                                        .OrderByDescending(c => c.FechaSubida)
                                        .Take(19)
                                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando canciones: " + ex.Message);
                canciones = new List<Cancion>();
            }
        }

        private void MostrarCancionesEnBotones()
        {
            Button[] botones = { button1, button2, button3, button4, button5, button6, button7, button8,
                button9, button10, button11, button12, button13, button14, button15, button16, button17
            , button18, button19};

            for (int i = 0; i < botones.Length; i++)
            {
                if (i < canciones.Count)
                {
                    botones[i].Text = canciones[i].Titulo;
                    botones[i].Tag = canciones[i];
                    botones[i].Enabled = true;
                }
                else
                {
                    botones[i].Text = "Vacío";
                    botones[i].Tag = null;
                    botones[i].Enabled = false;
                }
            }
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnSocial_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancion_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null && boton.Tag is Cancion cancion)
            {
                MessageBox.Show($"Título: {cancion.Titulo}\nAutor: {cancion.Autor}\nGénero: {cancion.Genero}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
