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
            txtDescripcion = new TextBox();
            label2 = new Label();
            btnCrear = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPerfil = new Button();
            btnMusica = new Button();
            btnPlayList = new Button();
            btnSocial = new Button();
            btnMensaje = new Button();
            btnSalir = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(245, 142);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // txtNombrePlaylist
            // 
            txtNombrePlaylist.Cursor = Cursors.IBeam;
            txtNombrePlaylist.Font = new Font("Segoe UI", 12F);
            txtNombrePlaylist.ForeColor = SystemColors.WindowFrame;
            txtNombrePlaylist.Location = new Point(245, 166);
            txtNombrePlaylist.Name = "txtNombrePlaylist";
            txtNombrePlaylist.PlaceholderText = "Nombre de tu playlist";
            txtNombrePlaylist.Size = new Size(319, 29);
            txtNombrePlaylist.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.ForeColor = SystemColors.WindowFrame;
            txtDescripcion.Location = new Point(245, 235);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Describe tu playlist...";
            txtDescripcion.Size = new Size(319, 82);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(245, 208);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 2;
            label2.Text = "Descripción: ";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Indigo;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(271, 335);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(95, 34);
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
            btnCancelar.Location = new Point(422, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(294, 94);
            label3.Name = "label3";
            label3.Size = new Size(206, 37);
            label3.TabIndex = 6;
            label3.Text = "Nueva PlayList";
            label3.Click += label3_Click;
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
            flowLayoutPanel1.TabIndex = 15;
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
            // NuevaPlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtNombrePlaylist);
            Controls.Add(label1);
            Name = "NuevaPlaylist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevaPlaylist";
            Load += NuevaPlaylist_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombrePlaylist;
        private TextBox txtDescripcion;
        private Label label2;
        private Button btnCrear;
        private Button btnCancelar;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPerfil;
        private Button btnMusica;
        private Button btnPlayList;
        private Button btnSocial;
        private Button btnMensaje;
        private Button btnSalir;
    }
}