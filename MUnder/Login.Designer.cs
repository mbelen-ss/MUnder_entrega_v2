namespace MUnder
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnRegistrarse = new Button();
            btnIniciar = new Button();
            label1 = new Label();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.WhiteSmoke;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatStyle = FlatStyle.Popup;
            btnRegistrarse.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = SystemColors.ControlText;
            btnRegistrarse.ImageAlign = ContentAlignment.MiddleRight;
            btnRegistrarse.Location = new Point(490, 392);
            btnRegistrarse.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(122, 52);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Indigo;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatStyle = FlatStyle.Popup;
            btnIniciar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = SystemColors.ControlLightLight;
            btnIniciar.Location = new Point(291, 392);
            btnIniciar.Margin = new Padding(3, 4, 3, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(145, 52);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(253, 96);
            label1.Name = "label1";
            label1.Size = new Size(267, 54);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txtClave
            // 
            txtClave.Cursor = Cursors.IBeam;
            txtClave.Font = new Font("Segoe UI", 12F);
            txtClave.ForeColor = SystemColors.WindowFrame;
            txtClave.Location = new Point(287, 316);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "******";
            txtClave.Size = new Size(350, 34);
            txtClave.TabIndex = 3;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Location = new Point(287, 215);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "tumail@gmail.com";
            txtUsuario.Size = new Size(350, 34);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 111);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(289, 180);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 6;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(290, 281);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 7;
            label4.Text = "Clave: ";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(513, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Controls.Add(btnRegistrarse);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarse;
        private Button btnIniciar;
        private Label label1;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
