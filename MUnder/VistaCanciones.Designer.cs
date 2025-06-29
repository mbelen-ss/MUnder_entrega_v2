namespace MUnder
{
    partial class VistaCanciones
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
            ListaCanciones = new DataGridView();
            btnSalir = new Button();
            label1 = new Label();
            txtPerfil = new Label();
            ((System.ComponentModel.ISupportInitialize)ListaCanciones).BeginInit();
            SuspendLayout();
            // 
            // ListaCanciones
            // 
            ListaCanciones.AllowUserToResizeColumns = false;
            ListaCanciones.BackgroundColor = Color.DimGray;
            ListaCanciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaCanciones.Location = new Point(70, 171);
            ListaCanciones.Margin = new Padding(3, 4, 3, 4);
            ListaCanciones.Name = "ListaCanciones";
            ListaCanciones.RowHeadersWidth = 51;
            ListaCanciones.ScrollBars = ScrollBars.Vertical;
            ListaCanciones.Size = new Size(763, 341);
            ListaCanciones.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Indigo;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(757, 22);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(145, 67);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Atras";
            btnSalir.UseMnemonic = false;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(70, 107);
            label1.Name = "label1";
            label1.Size = new Size(396, 42);
            label1.TabIndex = 15;
            label1.Text = "Guardados recientemente";
            label1.Click += label1_Click;
            // 
            // txtPerfil
            // 
            txtPerfil.AutoSize = true;
            txtPerfil.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txtPerfil.ForeColor = SystemColors.ButtonHighlight;
            txtPerfil.Location = new Point(70, 36);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(300, 35);
            txtPerfil.TabIndex = 16;
            txtPerfil.Text = ", estas son tus canciones";
            // 
            // VistaCanciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(914, 600);
            Controls.Add(txtPerfil);
            Controls.Add(label1);
            Controls.Add(ListaCanciones);
            Controls.Add(btnSalir);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VistaCanciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaCanciones";
            Load += VistaCanciones_Load;
            ((System.ComponentModel.ISupportInitialize)ListaCanciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ListaCanciones;
        private Button btnSalir;
        private Label label1;
        private Label txtPerfil;
    }
}