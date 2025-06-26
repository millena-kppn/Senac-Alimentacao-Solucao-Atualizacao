using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacAlimentacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            //exibe o nome do usuraio na tela principal
            lblMensagem.Text = "Bem vindo " + nome;
        }
        private void btnFecharOpcoes_Click(object sender, EventArgs e)
        {
            //fecha a tela principal
            Close();
            //cria uma instância do formulário de login
            var frmLogin = new FrmLogin();
            //exibe a tela de login
            frmLogin.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            //cria uma instância do formulário de cardápio
            var frmCardapio = new FrmCardapio();
            //exibe o formulário de cardápio em estilo modal()
            frmCardapio.ShowDialog();
        }

        private void btnMinimizarOpcoes_Click(object sender, EventArgs e)
        {
            //alter a o estado da tela 
            //para o estado minimizado
            WindowState = FormWindowState.Minimized;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            var frmPedidoCozinha = new FrmPedidoCozinha();
            frmPedidoCozinha.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
        }
    }
}
