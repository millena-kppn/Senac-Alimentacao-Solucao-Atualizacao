namespace SenacAlimentacao
{
    partial class FrmComanda
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
            panel1 = new Panel();
            btnSair = new Button();
            caixaTxtPesquisar = new TextBox();
            labelPesquisar = new Label();
            groupBoxComanda = new GroupBox();
            btnItens = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridViewComanda = new DataGridView();
            panel1.SuspendLayout();
            groupBoxComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComanda).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(labelPesquisar);
            panel1.Controls.Add(caixaTxtPesquisar);
            panel1.Controls.Add(btnSair);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 47);
            panel1.TabIndex = 5;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(753, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(46, 39);
            btnSair.TabIndex = 6;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // caixaTxtPesquisar
            // 
            caixaTxtPesquisar.Location = new Point(105, 11);
            caixaTxtPesquisar.Name = "caixaTxtPesquisar";
            caixaTxtPesquisar.Size = new Size(642, 31);
            caixaTxtPesquisar.TabIndex = 7;
            // 
            // labelPesquisar
            // 
            labelPesquisar.AutoSize = true;
            labelPesquisar.BackColor = Color.Black;
            labelPesquisar.ForeColor = Color.White;
            labelPesquisar.Location = new Point(13, 11);
            labelPesquisar.Name = "labelPesquisar";
            labelPesquisar.Size = new Size(86, 25);
            labelPesquisar.TabIndex = 8;
            labelPesquisar.Text = "Pesquisar";
            // 
            // groupBoxComanda
            // 
            groupBoxComanda.Controls.Add(btnItens);
            groupBoxComanda.Controls.Add(btnEditar);
            groupBoxComanda.Controls.Add(btnExcluir);
            groupBoxComanda.Controls.Add(dataGridViewComanda);
            groupBoxComanda.Location = new Point(12, 48);
            groupBoxComanda.Name = "groupBoxComanda";
            groupBoxComanda.Size = new Size(776, 390);
            groupBoxComanda.TabIndex = 6;
            groupBoxComanda.TabStop = false;
            groupBoxComanda.Text = "Comanda";
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
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(499, 344);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(128, 45);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "x Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // dataGridViewComanda
            // 
            dataGridViewComanda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComanda.Location = new Point(23, 70);
            dataGridViewComanda.Name = "dataGridViewComanda";
            dataGridViewComanda.RowHeadersWidth = 62;
            dataGridViewComanda.Size = new Size(722, 268);
            dataGridViewComanda.TabIndex = 0;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxComanda);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            Text = "FrmComanda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxComanda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewComanda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSair;
        private TextBox caixaTxtPesquisar;
        private Label labelPesquisar;
        private GroupBox groupBoxComanda;
        private Button btnItens;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridViewComanda;
    }
}