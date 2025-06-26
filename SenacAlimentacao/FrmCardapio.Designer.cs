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
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            labelPesquisar = new Label();
            caixaTxtPesquisar = new TextBox();
            groupBoxCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCardapio
            // 
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
            // btnEditar
            // 
            btnEditar.Location = new Point(633, 344);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = " * Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(499, 344);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(128, 45);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "x Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(722, 268);
            dataGridView1.TabIndex = 0;
            // 
            // labelPesquisar
            // 
            labelPesquisar.AutoSize = true;
            labelPesquisar.Location = new Point(12, 9);
            labelPesquisar.Name = "labelPesquisar";
            labelPesquisar.Size = new Size(86, 25);
            labelPesquisar.TabIndex = 3;
            labelPesquisar.Text = "Pesquisar";
            // caixaTxtPesquisar
            // 
            caixaTxtPesquisar.Location = new Point(139, 6);
            caixaTxtPesquisar.Name = "caixaTxtPesquisar";
            caixaTxtPesquisar.Size = new Size(510, 31);
            caixaTxtPesquisar.TabIndex = 4;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(caixaTxtPesquisar);
            Controls.Add(labelPesquisar);
            Controls.Add(groupBoxCardapio);
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
    }
}