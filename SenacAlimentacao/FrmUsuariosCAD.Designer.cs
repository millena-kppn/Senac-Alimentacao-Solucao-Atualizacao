namespace SenacAlimentacao
{
    partial class FrmUsuariosCAD
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
            panelUsuarioCAD = new Panel();
            labelUsuarioCAD = new Label();
            btnSairMenuUsuarioCAD = new Button();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textBoxEmail = new TextBox();
            textBoxSenha = new TextBox();
            textBoxConfirmarSenha = new TextBox();
            labelEmail = new Label();
            labelSenha = new Label();
            labelConfirmarSenha = new Label();
            comboBoxPerfil = new ComboBox();
            labelPerfil = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            panelUsuarioCAD.SuspendLayout();
            SuspendLayout();
            // 
            // panelUsuarioCAD
            // 
            panelUsuarioCAD.BackColor = Color.Black;
            panelUsuarioCAD.Controls.Add(labelUsuarioCAD);
            panelUsuarioCAD.Controls.Add(btnSairMenuUsuarioCAD);
            panelUsuarioCAD.Location = new Point(0, -4);
            panelUsuarioCAD.Name = "panelUsuarioCAD";
            panelUsuarioCAD.Size = new Size(802, 55);
            panelUsuarioCAD.TabIndex = 8;
            // 
            // labelUsuarioCAD
            // 
            labelUsuarioCAD.AutoSize = true;
            labelUsuarioCAD.BackColor = Color.Black;
            labelUsuarioCAD.ForeColor = Color.White;
            labelUsuarioCAD.Location = new Point(3, 10);
            labelUsuarioCAD.Name = "labelUsuarioCAD";
            labelUsuarioCAD.Size = new Size(158, 25);
            labelUsuarioCAD.TabIndex = 6;
            labelUsuarioCAD.Text = "Menu UsuarioCAD";
            // 
            // btnSairMenuUsuarioCAD
            // 
            btnSairMenuUsuarioCAD.BackColor = Color.Black;
            btnSairMenuUsuarioCAD.ForeColor = Color.White;
            btnSairMenuUsuarioCAD.Location = new Point(753, 3);
            btnSairMenuUsuarioCAD.Name = "btnSairMenuUsuarioCAD";
            btnSairMenuUsuarioCAD.Size = new Size(46, 39);
            btnSairMenuUsuarioCAD.TabIndex = 6;
            btnSairMenuUsuarioCAD.Text = "X";
            btnSairMenuUsuarioCAD.UseVisualStyleBackColor = false;
            btnSairMenuUsuarioCAD.Click += btnSairMenuUsuarioCAD_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 110);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(313, 31);
            textBoxNome.TabIndex = 9;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 82);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(61, 25);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 191);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(313, 31);
            textBoxEmail.TabIndex = 11;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(14, 270);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(313, 31);
            textBoxSenha.TabIndex = 12;
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Location = new Point(14, 362);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.Size = new Size(313, 31);
            textBoxConfirmarSenha.TabIndex = 13;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(14, 163);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(61, 25);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "E-mail";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(12, 242);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(60, 25);
            labelSenha.TabIndex = 15;
            labelSenha.Text = "Senha";
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.Location = new Point(12, 325);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(144, 25);
            labelConfirmarSenha.TabIndex = 16;
            labelConfirmarSenha.Text = "Confirmar Senha";
            // 
            // comboBoxPerfil
            // 
            comboBoxPerfil.FormattingEnabled = true;
            comboBoxPerfil.Items.AddRange(new object[] { "Administrador", "Programador", "Operador", "Jornalista", "Tecnico" });
            comboBoxPerfil.Location = new Point(465, 108);
            comboBoxPerfil.Name = "comboBoxPerfil";
            comboBoxPerfil.Size = new Size(289, 33);
            comboBoxPerfil.TabIndex = 17;
            // 
            // labelPerfil
            // 
            labelPerfil.AutoSize = true;
            labelPerfil.Location = new Point(465, 80);
            labelPerfil.Name = "labelPerfil";
            labelPerfil.Size = new Size(50, 25);
            labelPerfil.TabIndex = 18;
            labelPerfil.Text = "Perfil";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.MediumSeaGreen;
            btnSalvar.Location = new Point(642, 404);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(524, 404);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuariosCAD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(labelPerfil);
            Controls.Add(comboBoxPerfil);
            Controls.Add(labelConfirmarSenha);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxEmail);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(panelUsuarioCAD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuariosCAD";
            Text = "FrmUsuariosCAD";
            panelUsuarioCAD.ResumeLayout(false);
            panelUsuarioCAD.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUsuarioCAD;
        private Label labelUsuarioCAD;
        private Button btnSairMenuUsuarioCAD;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxEmail;
        private TextBox textBoxSenha;
        private TextBox textBoxConfirmarSenha;
        private Label labelEmail;
        private Label labelSenha;
        private Label labelConfirmarSenha;
        private ComboBox comboBoxPerfil;
        private Label labelPerfil;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}