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
    public partial class FrmUsuariosCAD : Form
    {
        public FrmUsuariosCAD()
        {
            InitializeComponent();
        }
        private void btnSalvarMenuUsuario_Click(object sender, EventArgs e)
        {
            // Conectar ao banco de dados
            using (var banco = new ComandaDBContext())
            {
                // Capturar os dados da tela
                string nome = textBoxNome.Text;
                string email = textBoxEmail.Text;
                string senha = textBoxSenha.Text;

                // Verifica se é uma edição ou inserção
                if (_usuarioSelecionado == null)
                {
                    // Criar um novo usuário
                    var usuario = new Usuario()
                    {
                        Nome = nome,
                        Email = email,
                        Senha = senha
                    };
                    // Adicionar o usuário e salvar as alterações no banco
                    banco.Usuarios.Add(usuario);
                }
                else
                {
                    // Atualizar o usuário existente
                    _usuarioSelecionado.Nome = nome;
                    _usuarioSelecionado.Email = email;
                    _usuarioSelecionado.Senha = senha;
                    banco.Usuarios.Update(_usuarioSelecionado);
                }

                banco.SaveChanges();
            }
            MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Fecha o formulário após salvar
        }
        private Usuario _usuarioSelecionado;
        public FrmUsuariosCAD(Usuario usuario) // Construtor para edição de usuário
        {
            InitializeComponent();
            _usuarioSelecionado = usuario; // Armazena o usuário selecionado
            CarregarDadosDoUsuario(); // Carrega os dados do usuário na tela
        }
        private void CarregarDadosDoUsuario()
        {
            if (_usuarioSelecionado != null) // Verifica se o usuário selecionado não é nulo
            {
                textBoxNome.Text = _usuarioSelecionado.Nome; // Preenche o campo de nome
                textBoxEmail.Text = _usuarioSelecionado.Email; // Preenche o campo de email
                textBoxSenha.Text = _usuarioSelecionado.Senha; // Preenche o campo de senha
            }
        }
        private void btnSairMenuUsuario_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
        private void FrmUsuariosCAD_Load(object sender, EventArgs e)
        {
            // Carrega os dados do usuário se estiver editando
            if (_usuarioSelecionado != null)
            {
                CarregarDadosDoUsuario();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário sem salvar
        }
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada
            textBoxNome.Clear();
            textBoxEmail.Clear();
            textBoxSenha.Clear();
            _usuarioSelecionado = null; // Reseta o usuário selecionado
        }
        private void FrmUsuariosCAD_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica se o usuário deseja realmente fechar o formulário
            if (MessageBox.Show("Deseja realmente fechar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // Cancela o fechamento do formulário
            }
        }
    }
}