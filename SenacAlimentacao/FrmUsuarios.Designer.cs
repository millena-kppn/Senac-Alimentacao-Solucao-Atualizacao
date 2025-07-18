namespace SenacAlimentacao
{
    partial class FrmUsuarios
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
            panelUsuario = new Panel();
            labelUsuario = new Label();
            btnSairMenuUsuario = new Button();
            dataGridViewUsuarios = new DataGridView();
            textBoxUsuarioPesquisar = new TextBox();
            labelPesquisarUsuario = new Label();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.Black;
            panelUsuario.Controls.Add(labelUsuario);
            panelUsuario.Controls.Add(btnSairMenuUsuario);
            panelUsuario.Location = new Point(0, 0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(806, 48);
            panelUsuario.TabIndex = 7;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.Black;
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(14, 10);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(122, 25);
            labelUsuario.TabIndex = 6;
            labelUsuario.Text = "Menu Usuario";
            // 
            // btnSairMenuUsuario
            // 
            btnSairMenuUsuario.BackColor = Color.Black;
            btnSairMenuUsuario.ForeColor = Color.White;
            btnSairMenuUsuario.Location = new Point(754, 3);
            btnSairMenuUsuario.Name = "btnSairMenuUsuario";
            btnSairMenuUsuario.Size = new Size(46, 39);
            btnSairMenuUsuario.TabIndex = 6;
            btnSairMenuUsuario.Text = "X";
            btnSairMenuUsuario.UseVisualStyleBackColor = false;
            btnSairMenuUsuario.Click += btnSairMenuUsuario_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(42, 130);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 62;
            dataGridViewUsuarios.Size = new Size(717, 253);
            dataGridViewUsuarios.TabIndex = 8;
            // 
            // textBoxUsuarioPesquisar
            // 
            textBoxUsuarioPesquisar.Location = new Point(199, 79);
            textBoxUsuarioPesquisar.Name = "textBoxUsuarioPesquisar";
            textBoxUsuarioPesquisar.Size = new Size(560, 31);
            textBoxUsuarioPesquisar.TabIndex = 9;
            // 
            // labelPesquisarUsuario
            // 
            labelPesquisarUsuario.AutoSize = true;
            labelPesquisarUsuario.Location = new Point(42, 79);
            labelPesquisarUsuario.Name = "labelPesquisarUsuario";
            labelPesquisarUsuario.Size = new Size(151, 25);
            labelPesquisarUsuario.TabIndex = 10;
            labelPesquisarUsuario.Text = "Pesquisar Usuario";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(647, 404);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "x Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.MediumAquamarine;
            btnEditar.Location = new Point(529, 404);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "* Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(255, 255, 128);
            btnAdicionar.Location = new Point(411, 404);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "+ Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdicionar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(labelPesquisarUsuario);
            Controls.Add(textBoxUsuarioPesquisar);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(panelUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUsuario;
        private Label labelUsuario;
        private Button btnSairMenuUsuario;
        private DataGridView dataGridViewUsuarios;
        private TextBox textBoxUsuarioPesquisar;
        private Label labelPesquisarUsuario;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnAdicionar;
    }
}