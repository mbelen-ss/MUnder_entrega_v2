namespace MUnder
{
    partial class NuevaPlaylist
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
            label1 = new Label();
            txtNombrePlaylist = new TextBox();
            btnCrear = new Button();
            label3 = new Label();
            btnSalir = new Button();
            txtPerfil = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(243, 186);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 0;
            // 
            // txtNombrePlaylist
            // 
            txtNombrePlaylist.Cursor = Cursors.IBeam;
            txtNombrePlaylist.Font = new Font("Segoe UI", 12F);
            txtNombrePlaylist.ForeColor = SystemColors.WindowFrame;
            txtNombrePlaylist.Location = new Point(243, 210);
            txtNombrePlaylist.Name = "txtNombrePlaylist";
            txtNombrePlaylist.PlaceholderText = "Nombre de tu playlist";
            txtNombrePlaylist.Size = new Size(319, 29);
            txtNombrePlaylist.TabIndex = 1;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Indigo;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(347, 263);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(95, 34);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(177, 146);
            label3.Name = "label3";
            label3.Size = new Size(430, 37);
            label3.TabIndex = 6;
            label3.Text = "Ingresa el nombre de tu PlayList";
            label3.Click += label3_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Indigo;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(662, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 50);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Atras";
            btnSalir.UseMnemonic = false;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtPerfil
            // 
            txtPerfil.AutoSize = true;
            txtPerfil.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txtPerfil.ForeColor = SystemColors.ButtonHighlight;
            txtPerfil.Location = new Point(38, 20);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(281, 28);
            txtPerfil.TabIndex = 7;
            txtPerfil.Text = ", creemos una nueva playlist";
            // 
            // NuevaPlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPerfil);
            Controls.Add(label3);
            Controls.Add(btnCrear);
            Controls.Add(btnSalir);
            Controls.Add(txtNombrePlaylist);
            Controls.Add(label1);
            Name = "NuevaPlaylist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevaPlaylist";
            Load += NuevaPlaylist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombrePlaylist;
        private Button btnCrear;
        private Label label3;
        private Button btnSalir;
        private Label txtPerfil;
    }
}