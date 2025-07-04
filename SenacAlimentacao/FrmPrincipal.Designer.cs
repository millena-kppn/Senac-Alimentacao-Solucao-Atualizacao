namespace SenacAlimentacao
{
    partial class FrmPrincipal
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
            groupBox1 = new GroupBox();
            btnUsuarios = new Button();
            btnPedidoCozinha = new Button();
            btnComanda = new Button();
            btnCardapio = new Button();
            btnFecharOpcoes = new Button();
            btnMinimizarOpcoes = new Button();
            lblMensagem = new Label();
            btnMesa = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMesa);
            groupBox1.Controls.Add(btnUsuarios);
            groupBox1.Controls.Add(btnPedidoCozinha);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 429);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Escolha seu serviço";
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(255, 128, 128);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 16F);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(578, 76);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(159, 164);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuário";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.BackColor = Color.FromArgb(128, 128, 255);
            btnPedidoCozinha.FlatAppearance.BorderSize = 0;
            btnPedidoCozinha.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnPedidoCozinha.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPedidoCozinha.FlatStyle = FlatStyle.Flat;
            btnPedidoCozinha.Font = new Font("Segoe UI", 16F);
            btnPedidoCozinha.ForeColor = Color.Black;
            btnPedidoCozinha.Location = new Point(398, 76);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.Size = new Size(159, 164);
            btnPedidoCozinha.TabIndex = 0;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.UseVisualStyleBackColor = false;
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.FromArgb(128, 255, 128);
            btnComanda.FlatAppearance.BorderSize = 0;
            btnComanda.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnComanda.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnComanda.FlatStyle = FlatStyle.Flat;
            btnComanda.Font = new Font("Segoe UI", 15F);
            btnComanda.ForeColor = Color.Black;
            btnComanda.Location = new Point(218, 76);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(159, 164);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.FromArgb(255, 255, 128);
            btnCardapio.FlatAppearance.BorderSize = 0;
            btnCardapio.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnCardapio.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCardapio.FlatStyle = FlatStyle.Flat;
            btnCardapio.Font = new Font("Segoe UI", 16F);
            btnCardapio.ForeColor = Color.Black;
            btnCardapio.Location = new Point(34, 76);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(159, 164);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnFecharOpcoes
            // 
            btnFecharOpcoes.BackColor = Color.Black;
            btnFecharOpcoes.FlatAppearance.BorderSize = 0;
            btnFecharOpcoes.ForeColor = Color.White;
            btnFecharOpcoes.Location = new Point(757, 2);
            btnFecharOpcoes.Name = "btnFecharOpcoes";
            btnFecharOpcoes.Size = new Size(41, 34);
            btnFecharOpcoes.TabIndex = 4;
            btnFecharOpcoes.Text = "X";
            btnFecharOpcoes.UseVisualStyleBackColor = false;
            btnFecharOpcoes.Click += btnFecharOpcoes_Click;
            // 
            // btnMinimizarOpcoes
            // 
            btnMinimizarOpcoes.BackColor = Color.Black;
            btnMinimizarOpcoes.FlatAppearance.BorderSize = 0;
            btnMinimizarOpcoes.Font = new Font("Segoe UI", 5F);
            btnMinimizarOpcoes.ForeColor = Color.White;
            btnMinimizarOpcoes.Location = new Point(710, 2);
            btnMinimizarOpcoes.Name = "btnMinimizarOpcoes";
            btnMinimizarOpcoes.Size = new Size(41, 34);
            btnMinimizarOpcoes.TabIndex = 5;
            btnMinimizarOpcoes.Text = "___";
            btnMinimizarOpcoes.UseVisualStyleBackColor = false;
            btnMinimizarOpcoes.Click += btnMinimizarOpcoes_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 16F);
            lblMensagem.ForeColor = Color.White;
            lblMensagem.Location = new Point(12, 9);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(213, 45);
            lblMensagem.TabIndex = 6;
            lblMensagem.Text = "lblMensagem";
            // 
            // btnMesa
            // 
            btnMesa.BackColor = Color.Silver;
            btnMesa.FlatAppearance.BorderSize = 0;
            btnMesa.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnMesa.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMesa.FlatStyle = FlatStyle.Flat;
            btnMesa.Font = new Font("Segoe UI", 16F);
            btnMesa.ForeColor = Color.Black;
            btnMesa.Location = new Point(282, 284);
            btnMesa.Name = "btnMesa";
            btnMesa.Size = new Size(220, 98);
            btnMesa.TabIndex = 1;
            btnMesa.Text = "Mesa";
            btnMesa.UseVisualStyleBackColor = false;
            btnMesa.Click += btnMesa_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 512);
            Controls.Add(lblMensagem);
            Controls.Add(btnMinimizarOpcoes);
            Controls.Add(btnFecharOpcoes);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCardapio;
        private Button btnUsuarios;
        private Button btnPedidoCozinha;
        private Button btnComanda;
        private Button btnFecharOpcoes;
        private Button btnMinimizarOpcoes;
        private Label lblMensagem;
        private Button btnMesa;
    }
}