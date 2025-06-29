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
    public partial class Verificacion : Form
    {
        private string codigoCorrecto;
        public Verificacion(string codigoOTP)
        {
            InitializeComponent();
            codigoCorrecto = codigoOTP;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificacion_Click(object sender, EventArgs e)
        {
            if (txtVerificacion.Text.Trim() == codigoCorrecto)
            {
                // Si el código es correcto, cerrar el formulario con éxito
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Código incorrecto. Intenta de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVerificacion.Clear();
                txtVerificacion.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin éxito
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
