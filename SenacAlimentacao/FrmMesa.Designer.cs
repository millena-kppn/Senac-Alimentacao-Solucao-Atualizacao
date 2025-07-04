namespace SenacAlimentacao
{
    partial class FrmMesa
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
            panelMesa = new Panel();
            labelMesa = new Label();
            btnSairMenuMesa = new Button();
            btnExcluirMenu = new Button();
            btnSalvarMenu = new Button();
            groupBoxMesa = new GroupBox();
            labelTituloMesa = new Label();
            textTituloMesa = new TextBox();
            panelMesa.SuspendLayout();
            groupBoxMesa.SuspendLayout();
            SuspendLayout();
            // 
            // panelMesa
            // 
            panelMesa.BackColor = Color.Black;
            panelMesa.Controls.Add(labelMesa);
            panelMesa.Controls.Add(btnSairMenuMesa);
            panelMesa.Location = new Point(-2, -2);
            panelMesa.Name = "panelMesa";
            panelMesa.Size = new Size(806, 49);
            panelMesa.TabIndex = 6;
            // 
            // labelMesa
            // 
            labelMesa.AutoSize = true;
            labelMesa.BackColor = Color.Black;
            labelMesa.ForeColor = Color.White;
            labelMesa.Location = new Point(14, 10);
            labelMesa.Name = "labelMesa";
            labelMesa.Size = new Size(104, 25);
            labelMesa.TabIndex = 6;
            labelMesa.Text = "Menu Mesa";
            // 
            // btnSairMenuMesa
            // 
            btnSairMenuMesa.BackColor = Color.Black;
            btnSairMenuMesa.ForeColor = Color.White;
            btnSairMenuMesa.Location = new Point(754, 3);
            btnSairMenuMesa.Name = "btnSairMenuMesa";
            btnSairMenuMesa.Size = new Size(46, 39);
            btnSairMenuMesa.TabIndex = 6;
            btnSairMenuMesa.Text = "X";
            btnSairMenuMesa.UseVisualStyleBackColor = false;
            btnSairMenuMesa.Click += btnSairMenuMesa_Click;
            // 
            // btnExcluirMenu
            // 
            btnExcluirMenu.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluirMenu.Location = new Point(572, 393);
            btnExcluirMenu.Name = "btnExcluirMenu";
            btnExcluirMenu.Size = new Size(105, 45);
            btnExcluirMenu.TabIndex = 7;
            btnExcluirMenu.Text = "x Cancelar";
            btnExcluirMenu.UseVisualStyleBackColor = false;
            // 
            // btnSalvarMenu
            // 
            btnSalvarMenu.BackColor = Color.MediumSeaGreen;
            btnSalvarMenu.Location = new Point(683, 393);
            btnSalvarMenu.Name = "btnSalvarMenu";
            btnSalvarMenu.Size = new Size(105, 45);
            btnSalvarMenu.TabIndex = 8;
            btnSalvarMenu.Text = " * Salvar";
            btnSalvarMenu.UseVisualStyleBackColor = false;
            btnSalvarMenu.Click += btnSalvarMenu_Click;
            // 
            // groupBoxMesa
            // 
            groupBoxMesa.Controls.Add(labelTituloMesa);
            groupBoxMesa.Controls.Add(textTituloMesa);
            groupBoxMesa.Location = new Point(7, 46);
            groupBoxMesa.Name = "groupBoxMesa";
            groupBoxMesa.Size = new Size(786, 341);
            groupBoxMesa.TabIndex = 9;
            groupBoxMesa.TabStop = false;
            groupBoxMesa.Text = "Mesa";
            // 
            // labelTituloMesa
            // 
            labelTituloMesa.AutoSize = true;
            labelTituloMesa.Location = new Point(36, 44);
            labelTituloMesa.Name = "labelTituloMesa";
            labelTituloMesa.Size = new Size(56, 25);
            labelTituloMesa.TabIndex = 2;
            labelTituloMesa.Text = "Titulo";
            // 
            // textTituloMesa
            // 
            textTituloMesa.Location = new Point(36, 72);
            textTituloMesa.Name = "textTituloMesa";
            textTituloMesa.Size = new Size(652, 31);
            textTituloMesa.TabIndex = 0;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxMesa);
            Controls.Add(btnSalvarMenu);
            Controls.Add(btnExcluirMenu);
            Controls.Add(panelMesa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesa";
            Text = "FrmMesa";
            panelMesa.ResumeLayout(false);
            panelMesa.PerformLayout();
            groupBoxMesa.ResumeLayout(false);
            groupBoxMesa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMesa;
        private Label labelMesa;
        private Button btnSairMenuMesa;
        private Button btnExcluirMenu;
        private Button btnSalvarMenu;
        private GroupBox groupBoxMesa;
        private Label labelTituloMesa;
        private TextBox textTituloMesa;
    }
}