namespace SenacAlimentacao
{
    partial class frmCardapioCAD
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
            labelCadatroCardapio = new Label();
            btnSair = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            groupBoxCardapio = new GroupBox();
            checkBoxPossuiPreparo = new CheckBox();
            labelPreco = new Label();
            textBoxPreco = new TextBox();
            richTxtBoxDescricao = new RichTextBox();
            labelDescricao = new Label();
            labelTitulo = new Label();
            textTitulo = new TextBox();
            panel1.SuspendLayout();
            groupBoxCardapio.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(labelCadatroCardapio);
            panel1.Controls.Add(btnSair);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 45);
            panel1.TabIndex = 5;
            // 
            // labelCadatroCardapio
            // 
            labelCadatroCardapio.AutoSize = true;
            labelCadatroCardapio.BackColor = Color.Black;
            labelCadatroCardapio.ForeColor = Color.White;
            labelCadatroCardapio.Location = new Point(14, 10);
            labelCadatroCardapio.Name = "labelCadatroCardapio";
            labelCadatroCardapio.Size = new Size(185, 25);
            labelCadatroCardapio.TabIndex = 6;
            labelCadatroCardapio.Text = "Cadastro de Cárdapio";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(754, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(46, 39);
            btnSair.TabIndex = 6;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(572, 406);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 45);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "x Cancelar";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.MediumSeaGreen;
            btnSalvar.Location = new Point(683, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 45);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = " * Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            //btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBoxCardapio
            // 
            groupBoxCardapio.Controls.Add(checkBoxPossuiPreparo);
            groupBoxCardapio.Controls.Add(labelPreco);
            groupBoxCardapio.Controls.Add(textBoxPreco);
            groupBoxCardapio.Controls.Add(richTxtBoxDescricao);
            groupBoxCardapio.Controls.Add(labelDescricao);
            groupBoxCardapio.Controls.Add(labelTitulo);
            groupBoxCardapio.Controls.Add(textTitulo);
            groupBoxCardapio.Location = new Point(2, 50);
            groupBoxCardapio.Name = "groupBoxCardapio";
            groupBoxCardapio.Size = new Size(786, 359);
            groupBoxCardapio.TabIndex = 8;
            groupBoxCardapio.TabStop = false;
            groupBoxCardapio.Text = "Cárdapio";
            // 
            // checkBoxPossuiPreparo
            // 
            checkBoxPossuiPreparo.AutoSize = true;
            checkBoxPossuiPreparo.Location = new Point(36, 330);
            checkBoxPossuiPreparo.Name = "checkBoxPossuiPreparo";
            checkBoxPossuiPreparo.Size = new Size(164, 29);
            checkBoxPossuiPreparo.TabIndex = 9;
            checkBoxPossuiPreparo.Text = "Possui preparo?";
            checkBoxPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Location = new Point(36, 256);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(60, 25);
            labelPreco.TabIndex = 6;
            labelPreco.Text = "Preço:";
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(36, 284);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(170, 31);
            textBoxPreco.TabIndex = 5;
            // 
            // richTxtBoxDescricao
            // 
            richTxtBoxDescricao.Location = new Point(36, 147);
            richTxtBoxDescricao.Name = "richTxtBoxDescricao";
            richTxtBoxDescricao.Size = new Size(652, 91);
            richTxtBoxDescricao.TabIndex = 4;
            richTxtBoxDescricao.Text = "";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(36, 119);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(88, 25);
            labelDescricao.TabIndex = 3;
            labelDescricao.Text = "Descrição";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(36, 44);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(56, 25);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Titulo";
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(36, 72);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(652, 31);
            textTitulo.TabIndex = 0;
            // 
            // frmCardapioCAD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(groupBoxCardapio);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCardapioCAD";
            Text = "frmCardapioCAD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxCardapio.ResumeLayout(false);
            groupBoxCardapio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSair;
        private Label labelCadatroCardapio;
        private Button btnExcluir;
        private Button btnSalvar;
        private GroupBox groupBoxCardapio;
        private RichTextBox richTxtBoxDescricao;
        private Label labelDescricao;
        private Label labelTitulo;
        private TextBox textTitulo;
        private Label labelPreco;
        private TextBox textBoxPreco;
        private CheckBox checkBoxPossuiPreparo;
    }
}