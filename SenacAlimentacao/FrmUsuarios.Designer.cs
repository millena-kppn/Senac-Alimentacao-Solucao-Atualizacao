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
            textBoxUsuarioPesquisar = new TextBox();
            labelUsuario = new Label();
            btnSairMenuUsuario = new Button();
            dataGridViewUsuarios = new DataGridView();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            groupBoxUsuario = new GroupBox();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            groupBoxUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.Black;
            panelUsuario.Controls.Add(textBoxUsuarioPesquisar);
            panelUsuario.Controls.Add(labelUsuario);
            panelUsuario.Controls.Add(btnSairMenuUsuario);
            panelUsuario.Location = new Point(0, 0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(806, 48);
            panelUsuario.TabIndex = 7;
            // 
            // textBoxUsuarioPesquisar
            // 
            textBoxUsuarioPesquisar.Location = new Point(106, 7);
            textBoxUsuarioPesquisar.Name = "textBoxUsuarioPesquisar";
            textBoxUsuarioPesquisar.Size = new Size(642, 31);
            textBoxUsuarioPesquisar.TabIndex = 9;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.Black;
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(14, 10);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(86, 25);
            labelUsuario.TabIndex = 6;
            labelUsuario.Text = "Pesquisar";
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
            dataGridViewUsuarios.Location = new Point(6, 71);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 62;
            dataGridViewUsuarios.Size = new Size(739, 253);
            dataGridViewUsuarios.TabIndex = 8;
            dataGridViewUsuarios.CellContentClick += dataGridViewUsuarios_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(663, 404);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "x Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.MediumAquamarine;
            btnEditar.Location = new Point(545, 404);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "* Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(255, 255, 128);
            btnAdicionar.Location = new Point(6, 31);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "+ Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // groupBoxUsuario
            // 
            groupBoxUsuario.Controls.Add(btnAdicionar);
            groupBoxUsuario.Controls.Add(dataGridViewUsuarios);
            groupBoxUsuario.Location = new Point(14, 54);
            groupBoxUsuario.Name = "groupBoxUsuario";
            groupBoxUsuario.Size = new Size(761, 344);
            groupBoxUsuario.TabIndex = 14;
            groupBoxUsuario.TabStop = false;
            groupBoxUsuario.Text = "Usuario";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxUsuario);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(panelUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            groupBoxUsuario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUsuario;
        private Label labelUsuario;
        private Button btnSairMenuUsuario;
        private DataGridView dataGridViewUsuarios;
        private TextBox textBoxUsuarioPesquisar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnAdicionar;
        private GroupBox groupBoxUsuario;
    }
}