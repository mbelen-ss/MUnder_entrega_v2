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
            btnCancelar = new Button();
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
            label1.Location = new Point(278, 248);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // txtNombrePlaylist
            // 
            txtNombrePlaylist.Cursor = Cursors.IBeam;
            txtNombrePlaylist.Font = new Font("Segoe UI", 12F);
            txtNombrePlaylist.ForeColor = SystemColors.WindowFrame;
            txtNombrePlaylist.Location = new Point(278, 280);
            txtNombrePlaylist.Margin = new Padding(3, 4, 3, 4);
            txtNombrePlaylist.Name = "txtNombrePlaylist";
            txtNombrePlaylist.PlaceholderText = "Nombre de tu playlist";
            txtNombrePlaylist.Size = new Size(364, 34);
            txtNombrePlaylist.TabIndex = 1;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Indigo;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(310, 351);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(109, 45);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(482, 351);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(202, 194);
            label3.Name = "label3";
            label3.Size = new Size(532, 46);
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
            btnSalir.Location = new Point(757, 13);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(145, 67);
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
            txtPerfil.Location = new Point(44, 27);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(347, 35);
            txtPerfil.TabIndex = 7;
            txtPerfil.Text = ", creemos una nueva playlist";
            // 
            // NuevaPlaylist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(914, 600);
            Controls.Add(txtPerfil);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(btnSalir);
            Controls.Add(txtNombrePlaylist);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnCancelar;
        private Label label3;
        private Button btnSalir;
        private Label txtPerfil;
    }
}