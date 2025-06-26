namespace SenacAlimentacao
{
    partial class FrmLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            panel2 = new Panel();
            btnFecharLogin = new Button();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnFecharLogin);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(270, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 450);
            panel2.TabIndex = 1;
            // 
            // btnFecharLogin
            // 
            btnFecharLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnFecharLogin.FlatAppearance.BorderSize = 0;
            btnFecharLogin.ForeColor = Color.White;
            btnFecharLogin.Location = new Point(489, 0);
            btnFecharLogin.Name = "btnFecharLogin";
            btnFecharLogin.Size = new Size(41, 34);
            btnFecharLogin.TabIndex = 3;
            btnFecharLogin.Text = "X";
            btnFecharLogin.UseVisualStyleBackColor = false;
            btnFecharLogin.Click += btnFecharLogin_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 16F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(103, 290);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(324, 58);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(64, 64, 64);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 16F);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(103, 209);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(424, 43);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "SENHA";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(64, 64, 64);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 16F);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(103, 112);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(424, 43);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(103, 229);
            label2.Name = "label2";
            label2.Size = new Size(324, 32);
            label2.TabIndex = 1;
            label2.Text = "_______________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 130);
            label1.Name = "label1";
            label1.Size = new Size(324, 32);
            label1.TabIndex = 1;
            label1.Text = "_______________________________";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtLogin;
        private Label label1;
        private TextBox txtSenha;
        private Label label2;
        private Button btnEntrar;
        private Button btnFecharLogin;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
    }
}
