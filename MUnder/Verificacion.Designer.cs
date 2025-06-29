namespace MUnder
{
    partial class Verificacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnVerificacion = new Button();
            txtVerificacion = new TextBox();
            btnCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVerificacion
            // 
            btnVerificacion.BackColor = Color.Indigo;
            btnVerificacion.FlatStyle = FlatStyle.Popup;
            btnVerificacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVerificacion.ForeColor = SystemColors.ButtonHighlight;
            btnVerificacion.Location = new Point(270, 220);
            btnVerificacion.Name = "btnVerificacion";
            btnVerificacion.Size = new Size(120, 40);
            btnVerificacion.TabIndex = 0;
            btnVerificacion.Text = "Verificar";
            btnVerificacion.UseVisualStyleBackColor = false;
            btnVerificacion.Click += btnVerificacion_Click;
            // 
            // txtVerificacion
            // 
            txtVerificacion.Font = new Font("Segoe UI", 12F);
            txtVerificacion.Location = new Point(250, 150);
            txtVerificacion.Name = "txtVerificacion";
            txtVerificacion.PlaceholderText = "Ingresá el código";
            txtVerificacion.Size = new Size(250, 34);
            txtVerificacion.TabIndex = 1;
            txtVerificacion.TextChanged += textBox1_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkViolet;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(410, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(260, 60);
            label1.Name = "label1";
            label1.Size = new Size(270, 41);
            label1.TabIndex = 3;
            label1.Text = "Verificá tu cuenta";
            // 
            // Verificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = ColorTranslator.FromHtml("#1E1B26");
            ClientSize = new Size(750, 350);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(txtVerificacion);
            Controls.Add(btnVerificacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Verificacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificacion;
        private TextBox txtVerificacion;
        private Button btnCancelar;
        private Label label1;
    }
}

