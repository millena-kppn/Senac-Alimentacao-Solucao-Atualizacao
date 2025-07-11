using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacAlimentacao
{
    public partial class frmCardapioCAD : Form
    {
        private CardapioItem _cardapioItem; // Variável privada para armazenar o item do cardápio que será editado ou cadastrado
        public frmCardapioCAD()// construtor para cadastrar um novo item no cardápio
        {
            InitializeComponent();
        }
        public frmCardapioCAD(CardapioItem cardapioItem)// construtor para editar um item existente no cardápio
        {
            _cardapioItem = cardapioItem; // Armazena o item do cardápio passado como parâmetro
            InitializeComponent();// inicializa os componentes do formulário

            //carregar os dados da tela 
            CarregarDadosDaTela();
        }
        //metodo para carregar os dados do item do cardápio na tela
        private void CarregarDadosDaTela()
        {
            //popular os campos do de texto e checkbox com os dados do item do cardápio
            if (_cardapioItem != null) // Verifica se o item do cardápio não é nulo
            {
                textTitulo.Text = _cardapioItem.Titulo; // Preenche o campo de título
                richTxtBoxDescricao.Text = _cardapioItem.Descricao; // Preenche o campo de descrição
                textBoxPreco.Text = _cardapioItem.Preco.ToString("F2"); // Preenche o campo de preço formatado com duas casas decimais
                checkBoxPossuiPreparo.Checked = _cardapioItem.PossuiPreparo; // Marca ou desmarca o checkbox de preparo
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //inserir 
            if (_cardapioItem == null)
            {
                //inserir metodo
                InserirCardapio();

            }
            //atualizar
            else 
            {
                AtualizarCardapio();
            }
        }

        private void AtualizarCardapio()//ira atualizar o cardápio
        {
            using (var banco = new ComandaDBContext())// ComandaDBContext é a classe que representa o banco de dados
            {
                //captar os dados da tela
                string titulo = textTitulo.Text;
                string descricao = richTxtBoxDescricao.Text;
                decimal.TryParse(textBoxPreco.Text, out decimal preco);
                bool possuiPreparo = checkBoxPossuiPreparo.Checked;
                //atualizar o cardápio
                var cardapioItem = banco.CardapioItens.Find(_cardapioItem.Id); // Busca o item do cardápio pelo ID
                cardapioItem.Titulo = titulo; // Atualiza o título
                cardapioItem.Descricao = descricao; // Atualiza a descrição
                cardapioItem.Preco = preco; // Atualiza o preço
                cardapioItem.PossuiPreparo = possuiPreparo; // Atualiza se possui preparo
                //salvar as alterações no banco de dados
                banco.CardapioItens.Update(cardapioItem); // Atualiza o item no banco de dados
                banco.SaveChanges(); // Salva as alterações no banco de dados
            }
            MessageBox.Show("Item do cardápio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); //fecha o formulário após salvar
        }
        private void InserirCardapio()//ira inserir um novo item no cardápio
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
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); //fecha o formulário
        }
    }
}
