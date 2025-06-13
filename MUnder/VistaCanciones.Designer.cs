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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPerfil = new Button();
            btnMusica = new Button();
            btnPlayList = new Button();
            btnSocial = new Button();
            btnMensaje = new Button();
            btnSalir = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ListaCanciones).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListaCanciones
            // 
            ListaCanciones.AllowUserToResizeColumns = false;
            ListaCanciones.BackgroundColor = Color.DimGray;
            ListaCanciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaCanciones.Location = new Point(61, 128);
            ListaCanciones.Name = "ListaCanciones";
            ListaCanciones.ScrollBars = ScrollBars.Vertical;
            ListaCanciones.Size = new Size(668, 256);
            ListaCanciones.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnPerfil);
            flowLayoutPanel1.Controls.Add(btnMusica);
            flowLayoutPanel1.Controls.Add(btnPlayList);
            flowLayoutPanel1.Controls.Add(btnSocial);
            flowLayoutPanel1.Controls.Add(btnMensaje);
            flowLayoutPanel1.Controls.Add(btnSalir);
            flowLayoutPanel1.Location = new Point(-1, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(802, 54);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.Indigo;
            btnPerfil.FlatStyle = FlatStyle.Popup;
            btnPerfil.Font = new Font("Segoe UI Semilight", 12F);
            btnPerfil.ForeColor = SystemColors.ButtonHighlight;
            btnPerfil.Location = new Point(3, 3);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(128, 50);
            btnPerfil.TabIndex = 0;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnMusica
            // 
            btnMusica.BackColor = Color.Indigo;
            btnMusica.FlatStyle = FlatStyle.Popup;
            btnMusica.Font = new Font("Segoe UI Semilight", 12F);
            btnMusica.ForeColor = SystemColors.ButtonHighlight;
            btnMusica.Location = new Point(137, 3);
            btnMusica.Name = "btnMusica";
            btnMusica.Size = new Size(128, 50);
            btnMusica.TabIndex = 1;
            btnMusica.Text = "Música";
            btnMusica.UseVisualStyleBackColor = false;
            btnMusica.Click += btnMusica_Click;
            // 
            // btnPlayList
            // 
            btnPlayList.BackColor = Color.DarkOrchid;
            btnPlayList.Cursor = Cursors.Hand;
            btnPlayList.FlatStyle = FlatStyle.Popup;
            btnPlayList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPlayList.ForeColor = SystemColors.ButtonHighlight;
            btnPlayList.Location = new Point(271, 3);
            btnPlayList.Name = "btnPlayList";
            btnPlayList.Size = new Size(128, 50);
            btnPlayList.TabIndex = 2;
            btnPlayList.Text = "PlayList";
            btnPlayList.UseVisualStyleBackColor = false;
            // 
            // btnSocial
            // 
            btnSocial.BackColor = Color.Indigo;
            btnSocial.FlatStyle = FlatStyle.Popup;
            btnSocial.Font = new Font("Segoe UI Semilight", 12F);
            btnSocial.ForeColor = SystemColors.ButtonHighlight;
            btnSocial.Location = new Point(405, 3);
            btnSocial.Name = "btnSocial";
            btnSocial.Size = new Size(128, 50);
            btnSocial.TabIndex = 3;
            btnSocial.Text = "Social";
            btnSocial.UseVisualStyleBackColor = false;
            // 
            // btnMensaje
            // 
            btnMensaje.BackColor = Color.Indigo;
            btnMensaje.FlatStyle = FlatStyle.Popup;
            btnMensaje.Font = new Font("Segoe UI Semilight", 12F);
            btnMensaje.ForeColor = SystemColors.ButtonHighlight;
            btnMensaje.Location = new Point(539, 3);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(127, 50);
            btnMensaje.TabIndex = 4;
            btnMensaje.Text = "Mensaje";
            btnMensaje.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Indigo;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(672, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 50);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Atras";
            btnSalir.UseMnemonic = false;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(61, 80);
            label1.Name = "label1";
            label1.Size = new Size(319, 35);
            label1.TabIndex = 15;
            label1.Text = "Guardados recientemente";
            label1.Click += label1_Click;
            // 
            // VistaCanciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ListaCanciones);
            Name = "VistaCanciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaCanciones";
            Load += VistaCanciones_Load;
            ((System.ComponentModel.ISupportInitialize)ListaCanciones).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ListaCanciones;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPerfil;
        private Button btnMusica;
        private Button btnPlayList;
        private Button btnSocial;
        private Button btnMensaje;
        private Button btnSalir;
        private Label label1;
    }
}