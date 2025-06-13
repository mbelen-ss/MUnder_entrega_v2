namespace MUnder
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            label1 = new Label();
            label2 = new Label();
            btnPerfil = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMusica = new Button();
            btnPlayList = new Button();
            btnSocial = new Button();
            btnMensaje = new Button();
            btnSalir = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(200, 110);
            label1.Name = "label1";
            label1.Size = new Size(233, 47);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(190, 162);
            label2.Name = "label2";
            label2.Size = new Size(415, 32);
            label2.TabIndex = 1;
            label2.Text = "Tu red social de música underground";
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.Indigo;
            btnPerfil.Cursor = Cursors.Hand;
            btnPerfil.FlatStyle = FlatStyle.Popup;
            btnPerfil.Font = new Font("Segoe UI Semilight", 12F);
            btnPerfil.ForeColor = SystemColors.ButtonHighlight;
            btnPerfil.Location = new Point(3, 3);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(128, 50);
            btnPerfil.TabIndex = 0;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
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
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnMusica
            // 
            btnMusica.BackColor = Color.Indigo;
            btnMusica.Cursor = Cursors.Hand;
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
            btnPlayList.BackColor = Color.Indigo;
            btnPlayList.Cursor = Cursors.Hand;
            btnPlayList.FlatStyle = FlatStyle.Popup;
            btnPlayList.Font = new Font("Segoe UI Semilight", 12F);
            btnPlayList.ForeColor = SystemColors.ButtonHighlight;
            btnPlayList.Location = new Point(271, 3);
            btnPlayList.Name = "btnPlayList";
            btnPlayList.Size = new Size(128, 50);
            btnPlayList.TabIndex = 2;
            btnPlayList.Text = "PlayList";
            btnPlayList.UseVisualStyleBackColor = false;
            btnPlayList.Click += btnPlayList_Click;
            // 
            // btnSocial
            // 
            btnSocial.BackColor = Color.Indigo;
            btnSocial.Cursor = Cursors.Hand;
            btnSocial.FlatStyle = FlatStyle.Popup;
            btnSocial.Font = new Font("Segoe UI Semilight", 12F);
            btnSocial.ForeColor = SystemColors.ButtonHighlight;
            btnSocial.Location = new Point(405, 3);
            btnSocial.Name = "btnSocial";
            btnSocial.Size = new Size(128, 50);
            btnSocial.TabIndex = 3;
            btnSocial.Text = "Social";
            btnSocial.UseVisualStyleBackColor = false;
            btnSocial.Click += btnSocial_Click;
            // 
            // btnMensaje
            // 
            btnMensaje.BackColor = Color.Indigo;
            btnMensaje.Cursor = Cursors.Hand;
            btnMensaje.FlatStyle = FlatStyle.Popup;
            btnMensaje.Font = new Font("Segoe UI Semilight", 12F);
            btnMensaje.ForeColor = SystemColors.ButtonHighlight;
            btnMensaje.Location = new Point(539, 3);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(127, 50);
            btnMensaje.TabIndex = 4;
            btnMensaje.Text = "Mensaje";
            btnMensaje.UseVisualStyleBackColor = false;
            btnMensaje.Click += btnMensaje_Click;
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
            btnSalir.Text = "Cerrar Sesión";
            btnSalir.UseMnemonic = false;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Indigo;
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel2.Location = new Point(103, 243);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(602, 93);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(349, 30);
            label3.TabIndex = 0;
            label3.Text = "🎵 Explora música underground";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 30);
            label4.Name = "label4";
            label4.Size = new Size(594, 50);
            label4.TabIndex = 1;
            label4.Text = "Descubre nuevos artistas, crea playlists y conecta con la comunidad    musical alternativa.";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(431, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaPrincipal";
            Load += PantallaPrincipal_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnPerfil;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnMusica;
        private Button btnPlayList;
        private Button btnSocial;
        private Button btnMensaje;
        private Button btnSalir;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}