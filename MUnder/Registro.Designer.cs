namespace MUnder
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtContrasena = new TextBox();
            txtTelefono = new TextBox();
            btnRegistrarse = new Button();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(267, 55);
            label1.Name = "label1";
            label1.Size = new Size(245, 46);
            label1.TabIndex = 0;
            label1.Text = "Registrarse en";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(274, 128);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(274, 220);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(274, 311);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 3;
            label4.Text = "Contraseña: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(274, 396);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 4;
            label5.Text = "Teléfono: ";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(274, 160);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Tu nombre completo";
            txtNombre.Size = new Size(338, 34);
            txtNombre.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = SystemColors.WindowFrame;
            txtEmail.Location = new Point(274, 252);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "tumail@gmail.com";
            txtEmail.Size = new Size(338, 34);
            txtEmail.TabIndex = 7;
            // 
            // txtContrasena
            // 
            txtContrasena.Cursor = Cursors.IBeam;
            txtContrasena.Font = new Font("Segoe UI", 12F);
            txtContrasena.ForeColor = SystemColors.WindowFrame;
            txtContrasena.Location = new Point(274, 343);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = "******";
            txtContrasena.Size = new Size(338, 34);
            txtContrasena.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.ForeColor = SystemColors.WindowFrame;
            txtTelefono.Location = new Point(274, 428);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "+54 1234-5678";
            txtTelefono.Size = new Size(338, 34);
            txtTelefono.TabIndex = 9;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.Indigo;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatStyle = FlatStyle.Popup;
            btnRegistrarse.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(286, 500);
            btnRegistrarse.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(122, 47);
            btnRegistrarse.TabIndex = 13;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.WhiteSmoke;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(480, 500);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 47);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(489, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(918, 592);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtTelefono);
            Controls.Add(txtContrasena);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private TextBox txtTelefono;
        private Button btnRegistrarse;
        private Button btnVolver;
        private PictureBox pictureBox1;
    }
}