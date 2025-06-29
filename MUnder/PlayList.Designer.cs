namespace MUnder
{
    partial class PlayList
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
            btnRockAlter2024 = new Button();
            btnSalir = new Button();
            label1 = new Label();
            btnIndieFolkArg = new Button();
            btnHipHopUnder = new Button();
            btnCreaPlayList = new Button();
            groupBox1 = new GroupBox();
            txtPerfil = new Label();
            btnElectroExperimental = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRockAlter2024
            // 
            btnRockAlter2024.BackColor = Color.Transparent;
            btnRockAlter2024.Cursor = Cursors.Hand;
            btnRockAlter2024.FlatStyle = FlatStyle.Popup;
            btnRockAlter2024.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnRockAlter2024.ForeColor = SystemColors.ButtonHighlight;
            btnRockAlter2024.Location = new Point(42, 81);
            btnRockAlter2024.Name = "btnRockAlter2024";
            btnRockAlter2024.Size = new Size(269, 36);
            btnRockAlter2024.TabIndex = 11;
            btnRockAlter2024.Text = "Rock Alternativo 2024";
            btnRockAlter2024.TextAlign = ContentAlignment.TopLeft;
            btnRockAlter2024.UseVisualStyleBackColor = false;
            btnRockAlter2024.Click += btnRockAlter2024_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Indigo;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(662, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 50);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Atrás";
            btnSalir.UseMnemonic = false;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(72, 86);
            label1.Name = "label1";
            label1.Size = new Size(164, 35);
            label1.TabIndex = 4;
            label1.Text = "Mis PlayLists";
            // 
            // btnIndieFolkArg
            // 
            btnIndieFolkArg.BackColor = Color.Transparent;
            btnIndieFolkArg.Cursor = Cursors.Hand;
            btnIndieFolkArg.FlatStyle = FlatStyle.Popup;
            btnIndieFolkArg.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnIndieFolkArg.ForeColor = SystemColors.ButtonHighlight;
            btnIndieFolkArg.Location = new Point(42, 197);
            btnIndieFolkArg.Name = "btnIndieFolkArg";
            btnIndieFolkArg.Size = new Size(233, 32);
            btnIndieFolkArg.TabIndex = 14;
            btnIndieFolkArg.Text = "Indie Folk Argentino";
            btnIndieFolkArg.UseVisualStyleBackColor = false;
            btnIndieFolkArg.Click += btnIndieFolkArg_Click_1;
            // 
            // btnHipHopUnder
            // 
            btnHipHopUnder.Cursor = Cursors.Hand;
            btnHipHopUnder.FlatStyle = FlatStyle.Popup;
            btnHipHopUnder.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnHipHopUnder.ForeColor = SystemColors.ButtonHighlight;
            btnHipHopUnder.Location = new Point(42, 22);
            btnHipHopUnder.Name = "btnHipHopUnder";
            btnHipHopUnder.Size = new Size(277, 36);
            btnHipHopUnder.TabIndex = 15;
            btnHipHopUnder.Text = "Hip Hop Underground";
            btnHipHopUnder.UseVisualStyleBackColor = true;
            btnHipHopUnder.Click += btnHipHopUnder_Click_1;
            // 
            // btnCreaPlayList
            // 
            btnCreaPlayList.BackColor = Color.Indigo;
            btnCreaPlayList.Cursor = Cursors.Hand;
            btnCreaPlayList.FlatStyle = FlatStyle.Popup;
            btnCreaPlayList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCreaPlayList.ForeColor = Color.White;
            btnCreaPlayList.Location = new Point(72, 388);
            btnCreaPlayList.Name = "btnCreaPlayList";
            btnCreaPlayList.Size = new Size(164, 36);
            btnCreaPlayList.TabIndex = 11;
            btnCreaPlayList.Text = "Crea Nueva PlayList";
            btnCreaPlayList.UseVisualStyleBackColor = false;
            btnCreaPlayList.Click += btnCreaPlayList_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnHipHopUnder);
            groupBox1.Controls.Add(btnRockAlter2024);
            groupBox1.Controls.Add(btnIndieFolkArg);
            groupBox1.Controls.Add(btnElectroExperimental);
            groupBox1.Location = new Point(72, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 254);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = ".";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtPerfil
            // 
            txtPerfil.AutoSize = true;
            txtPerfil.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txtPerfil.ForeColor = SystemColors.ButtonHighlight;
            txtPerfil.Location = new Point(72, 16);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(224, 28);
            txtPerfil.TabIndex = 13;
            txtPerfil.Text = ", estas son tus PlayList";
            txtPerfil.Click += txtPerfil_Click;
            // 
            // btnElectroExperimental
            // 
            btnElectroExperimental.BackColor = Color.Transparent;
            btnElectroExperimental.Cursor = Cursors.Hand;
            btnElectroExperimental.FlatStyle = FlatStyle.Popup;
            btnElectroExperimental.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnElectroExperimental.ForeColor = SystemColors.ButtonHighlight;
            btnElectroExperimental.Location = new Point(42, 139);
            btnElectroExperimental.Name = "btnElectroExperimental";
            btnElectroExperimental.Size = new Size(265, 35);
            btnElectroExperimental.TabIndex = 13;
            btnElectroExperimental.Text = "Electrónica Experimental";
            btnElectroExperimental.UseVisualStyleBackColor = false;
            btnElectroExperimental.Click += btnElectroExperimental_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(359, 22);
            button1.Name = "button1";
            button1.Size = new Size(277, 36);
            button1.TabIndex = 16;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(359, 82);
            button2.Name = "button2";
            button2.Size = new Size(277, 36);
            button2.TabIndex = 17;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(359, 139);
            button3.Name = "button3";
            button3.Size = new Size(277, 36);
            button3.TabIndex = 18;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(359, 197);
            button4.Name = "button4";
            button4.Size = new Size(277, 36);
            button4.TabIndex = 19;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            // 
            // PlayList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPerfil);
            Controls.Add(groupBox1);
            Controls.Add(btnCreaPlayList);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Name = "PlayList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayList";
            Load += PlayList_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private Label label1;
        private Button btnRockAlter2024;
        private Button btnIndieFolkArg;
        private Button btnHipHopUnder;
        private Button btnCreaPlayList;
        private GroupBox groupBox1;
        private Label txtPerfil;
        private Button btnElectroExperimental;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}