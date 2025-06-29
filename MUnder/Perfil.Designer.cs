namespace MUnder
{
    partial class Perfil
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblNombreUsuario;
        private Label lblEmail;
        private Label lblEmailUsuario;
        private Button btnCerrarSesion;
        private Button btnEditarPerfil;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblNombreUsuario = new Label();
            lblEmail = new Label();
            lblEmailUsuario = new Label();
            btnCerrarSesion = new Button();
            btnEditarPerfil = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(35, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(86, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Perfil";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(35, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(88, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 14F);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(131, 82);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(124, 25);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "Nombre User";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(35, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblEmailUsuario
            // 
            lblEmailUsuario.AutoSize = true;
            lblEmailUsuario.Font = new Font("Segoe UI", 14F);
            lblEmailUsuario.ForeColor = Color.White;
            lblEmailUsuario.Location = new Point(131, 120);
            lblEmailUsuario.Name = "lblEmailUsuario";
            lblEmailUsuario.Size = new Size(179, 25);
            lblEmailUsuario.TabIndex = 4;
            lblEmailUsuario.Text = "email@usuario.com";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.WhiteSmoke;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(201, 172);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(140, 38);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Atrás";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.BackColor = Color.Indigo;
            btnEditarPerfil.Cursor = Cursors.Hand;
            btnEditarPerfil.FlatStyle = FlatStyle.Popup;
            btnEditarPerfil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEditarPerfil.ForeColor = Color.White;
            btnEditarPerfil.Location = new Point(39, 172);
            btnEditarPerfil.Margin = new Padding(3, 2, 3, 2);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.Size = new Size(140, 38);
            btnEditarPerfil.TabIndex = 5;
            btnEditarPerfil.Text = "Editar Perfil";
            btnEditarPerfil.UseVisualStyleBackColor = false;
            btnEditarPerfil.Click += btnEditarPerfil_Click;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 27, 38);
            ClientSize = new Size(394, 240);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblEmail);
            Controls.Add(lblEmailUsuario);
            Controls.Add(btnEditarPerfil);
            Controls.Add(btnCerrarSesion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Perfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil de Usuario";
            Load += Perfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}