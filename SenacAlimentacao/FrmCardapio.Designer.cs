namespace SenacAlimentacao
{
    partial class FrmCardapio
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
            groupBoxCardapio = new GroupBox();
            btnItens = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            labelPesquisar = new Label();
            caixaTxtPesquisar = new TextBox();
            btnSair = new Button();
            panel1 = new Panel();
            groupBoxCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCardapio
            // 
            groupBoxCardapio.Controls.Add(btnItens);
            groupBoxCardapio.Controls.Add(btnEditar);
            groupBoxCardapio.Controls.Add(btnExcluir);
            groupBoxCardapio.Controls.Add(dataGridView1);
            groupBoxCardapio.Location = new Point(12, 48);
            groupBoxCardapio.Name = "groupBoxCardapio";
            groupBoxCardapio.Size = new Size(776, 390);
            groupBoxCardapio.TabIndex = 0;
            groupBoxCardapio.TabStop = false;
            groupBoxCardapio.Text = "Cardapio";
            // 
            // btnItens
            // 
            btnItens.BackColor = Color.FromArgb(255, 255, 128);
            btnItens.Location = new Point(23, 30);
            btnItens.Name = "btnItens";
            btnItens.Size = new Size(105, 34);
            btnItens.TabIndex = 3;
            btnItens.Text = "+ Itens";
            btnItens.UseVisualStyleBackColor = false;
            btnItens.Click += btnItens_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.MediumSeaGreen;
            btnEditar.Location = new Point(633, 344);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = " * Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(499, 344);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(128, 45);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "x Cancelar";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(722, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // labelPesquisar
            // 
            labelPesquisar.AutoSize = true;
            labelPesquisar.BackColor = Color.Black;
            labelPesquisar.ForeColor = Color.White;
            labelPesquisar.Location = new Point(12, 9);
            labelPesquisar.Name = "labelPesquisar";
            labelPesquisar.Size = new Size(86, 25);
            labelPesquisar.TabIndex = 3;
            labelPesquisar.Text = "Pesquisar";
            // 
            // caixaTxtPesquisar
            // 
            caixaTxtPesquisar.Location = new Point(139, 6);
            caixaTxtPesquisar.Name = "caixaTxtPesquisar";
            caixaTxtPesquisar.Size = new Size(510, 31);
            caixaTxtPesquisar.TabIndex = 4;
            caixaTxtPesquisar.TextChanged += caixaTxtPesquisar_TextChanged;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(752, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(46, 39);
            btnSair.TabIndex = 4;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 47);
            panel1.TabIndex = 4;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(caixaTxtPesquisar);
            Controls.Add(labelPesquisar);
            Controls.Add(groupBoxCardapio);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            Text = "FrmCardapio";
            Load += FrmCardapio_Load;
            groupBoxCardapio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxCardapio;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        private Label labelPesquisar;
        private TextBox caixaTxtPesquisar;
        private Button btnSair;
        private Button btnItens;
        private Panel panel1;
    }
}