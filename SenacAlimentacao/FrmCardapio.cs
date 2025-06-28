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
                var cardapios = bd.CardapioItens.ToList(); //busca todos os itens do cardápio
                                                           //popular o grid com os itens do cardápio
                dataGridView1.DataSource = cardapios; //atribui a lista de itens do cardápio ao DataGridView

            }
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            new frmCardapioCAD().ShowDialog(); //abre o formulário de cadastro de itens do cardápio
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
