namespace SenacAlimentacao
{
    partial class FrmMesaCAD
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
            panelMesaCAD = new Panel();
            labelMesaCAD = new Label();
            btnExcluirMenuCAD = new Button();
            btnSalvarMenuCAD = new Button();
            groupBoxMesaCAD = new GroupBox();
            dataGridViewMesaCAD = new DataGridView();
            panelMesaCAD.SuspendLayout();
            groupBoxMesaCAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesaCAD).BeginInit();
            SuspendLayout();
            // 
            // panelMesaCAD
            // 
            panelMesaCAD.BackColor = Color.Black;
            panelMesaCAD.Controls.Add(labelMesaCAD);
            panelMesaCAD.Location = new Point(0, 0);
            panelMesaCAD.Name = "panelMesaCAD";
            panelMesaCAD.Size = new Size(803, 48);
            panelMesaCAD.TabIndex = 5;
            // 
            // labelMesaCAD
            // 
            labelMesaCAD.AutoSize = true;
            labelMesaCAD.BackColor = Color.Black;
            labelMesaCAD.ForeColor = Color.White;
            labelMesaCAD.Location = new Point(12, 9);
            labelMesaCAD.Name = "labelMesaCAD";
            labelMesaCAD.Size = new Size(95, 25);
            labelMesaCAD.TabIndex = 4;
            labelMesaCAD.Text = "Mesa CAD";
            // 
            // btnExcluirMenuCAD
            // 
            btnExcluirMenuCAD.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluirMenuCAD.Location = new Point(572, 393);
            btnExcluirMenuCAD.Name = "btnExcluirMenuCAD";
            btnExcluirMenuCAD.Size = new Size(105, 45);
            btnExcluirMenuCAD.TabIndex = 8;
            btnExcluirMenuCAD.Text = "x Cancelar";
            btnExcluirMenuCAD.UseVisualStyleBackColor = false;
            // 
            // btnSalvarMenuCAD
            // 
            btnSalvarMenuCAD.BackColor = Color.MediumSeaGreen;
            btnSalvarMenuCAD.Location = new Point(683, 393);
            btnSalvarMenuCAD.Name = "btnSalvarMenuCAD";
            btnSalvarMenuCAD.Size = new Size(105, 45);
            btnSalvarMenuCAD.TabIndex = 9;
            btnSalvarMenuCAD.Text = " * Salvar";
            btnSalvarMenuCAD.UseVisualStyleBackColor = false;
            // 
            // groupBoxMesaCAD
            // 
            groupBoxMesaCAD.Controls.Add(dataGridViewMesaCAD);
            groupBoxMesaCAD.Location = new Point(12, 79);
            groupBoxMesaCAD.Name = "groupBoxMesaCAD";
            groupBoxMesaCAD.Size = new Size(776, 308);
            groupBoxMesaCAD.TabIndex = 10;
            groupBoxMesaCAD.TabStop = false;
            groupBoxMesaCAD.Text = "Mesa";
            // 
            // dataGridViewMesaCAD
            // 
            dataGridViewMesaCAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMesaCAD.Location = new Point(6, 30);
            dataGridViewMesaCAD.Name = "dataGridViewMesaCAD";
            dataGridViewMesaCAD.RowHeadersWidth = 62;
            dataGridViewMesaCAD.Size = new Size(764, 272);
            dataGridViewMesaCAD.TabIndex = 0;
            // 
            // FrmMesaCAD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxMesaCAD);
            Controls.Add(btnSalvarMenuCAD);
            Controls.Add(btnExcluirMenuCAD);
            Controls.Add(panelMesaCAD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaCAD";
            Text = "FrmMesaCAD";
            panelMesaCAD.ResumeLayout(false);
            panelMesaCAD.PerformLayout();
            groupBoxMesaCAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesaCAD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMesaCAD;
        private Label labelMesaCAD;
        private Button btnExcluirMenuCAD;
        private Button btnSalvarMenuCAD;
        private GroupBox groupBoxMesaCAD;
        private DataGridView dataGridViewMesaCAD;
    }
}