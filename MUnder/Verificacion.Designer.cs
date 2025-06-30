namespace MUnder
{
    partial class Verificacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVerificacion = new Button();
            txtVerificacion = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnVerificacion
            // 
            btnVerificacion.Location = new Point(280, 193);
            btnVerificacion.Name = "btnVerificacion";
            btnVerificacion.Size = new Size(75, 23);
            btnVerificacion.TabIndex = 0;
            btnVerificacion.Text = "Verificar";
            btnVerificacion.UseVisualStyleBackColor = true;
            btnVerificacion.Click += btnVerificacion_Click;
            // 
            // txtVerificacion
            // 
            txtVerificacion.Location = new Point(349, 116);
            txtVerificacion.Name = "txtVerificacion";
            txtVerificacion.Size = new Size(100, 23);
            txtVerificacion.TabIndex = 1;
            txtVerificacion.TextChanged += textBox1_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(416, 193);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.RightToLeft = RightToLeft.No;
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Verificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(txtVerificacion);
            Controls.Add(btnVerificacion);
            Name = "Verificacion";
            Text = "Verificacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificacion;
        private TextBox txtVerificacion;
        private Button btnCancelar;
    }
}