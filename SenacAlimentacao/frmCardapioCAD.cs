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
    public partial class frmCardapioCAD : Form
    {
        public frmCardapioCAD()
        {
            InitializeComponent();
        }
        public frmCardapioCAD(CardapioItem cardapioItem)
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //conectar
            using (var banco = new ComandaDBContext())// ComandaDBContext é a classe que representa o banco de dados
            {
                //captar os dados da tela 
                string titulo = textTitulo.Text;
                string descricao = richTxtBoxDescricao.Text;
                decimal.TryParse(textBoxPreco.Text, out decimal preco);
                bool possuiPreparo = checkBoxPossuiPreparo.Checked;
                //criar um novo cadarpio 
                var cardapioItem = new CardapioItem()//var criada 
                {
                    Titulo = titulo,
                    Descricao = descricao,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                //adicionar o cardapio // salvar as alterações no banco 
                banco.CardapioItens.Add(cardapioItem);//oq esta em parenteses e o nome da var criada logo em cima
                banco.SaveChanges(); //salva as alterações no banco de dados
            }
            MessageBox.Show("Item do cardápio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); //fecha o formulário após salvar

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); //fecha o formulário
        }
    }
}
