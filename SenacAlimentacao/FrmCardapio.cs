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
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();// chama o método para buscar os itens do cardápio
        }

        private void BuscarCardapio()
        {
            //conectar no banco de dados 
            using (var bd = new ComandaDBContext()) // instância do banco de dados ComandaDBContext
            {
                //consultar a tabela CardapioItem 
                var cardapios = bd.CardapioItens.AsQueryable(); //busca todos os itens do cardápio
                                                           //popular o grid com os itens do cardápio
                if(!string.IsNullOrEmpty(caixaTxtPesquisar.Text))
                {
                    //se o campo de pesquisa não estiver vazio, filtra os itens do cardápio pelo título
                    cardapios = cardapios.Where(c => c.Titulo.Contains(caixaTxtPesquisar.Text) || c.Descricao.Contains(caixaTxtPesquisar.Text));
                }
                //atribui a lista de itens do cardápio ao DataGridView
                dataGridView1.DataSource = cardapios.ToList(); //atribui a lista de itens do cardápio ao DataGridView

            }
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            new frmCardapioCAD().ShowDialog(); //abre o formulário de cadastro de itens do cardápio
            BuscarCardapio(); //atualiza a lista de itens do cardápio após o cadastro
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); //fecha o formulário atual
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Close(); //fecha o formulário atual
        }

        private void caixaTxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            //chamar o método de busca com o texto digitado 
            BuscarCardapio();
        }
    }
}
