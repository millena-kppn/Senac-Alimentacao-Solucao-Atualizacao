
namespace SenacAlimentacao
{
    public partial class FrmUsuarios : Form
    {
        Usuario? UsuarioSelecionado;
        public FrmUsuarios()
        {
            InitializeComponent();
        }


        private void textBoxUsuarioPesquisar_Click(object sender, EventArgs e)
        {
            BuscarUsuarios(); //chama o método de busca com o texto digitado
        }
        private void btnSairMenuUsuario_Click(object sender, EventArgs e)
        {
            this.Close();// Fecha o formulário atual
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmUsuariosCAD().Show();//Abre o formulário de cadastro de usuário em modo de diálogo
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0) //verifica se há uma linha selecionada
            {
                var usuarioSelecionado = dataGridViewUsuarios.SelectedRows[0].DataBoundItem as Usuario; //pega o usuário selecionado
                if (usuarioSelecionado != null)
                {
                    new FrmUsuariosCAD(usuarioSelecionado).ShowDialog(); //abre o formulário de edição com o usuário selecionado
                    BuscarUsuarios(); //atualiza a lista de usuários após a edição
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            BuscarUsuarios(); //chama o método para buscar os usuários ao carregar o formulário
        }
        private void BuscarUsuarios()
        {
            using (var bd = new ComandaDBContext()) //conectar ao banco de dados
            {
                var usuarios = bd.Usuarios.AsQueryable(); //consulta a tabela Usuarios
                if (!string.IsNullOrEmpty(textBoxUsuarioPesquisar.Text))
                {
                    //se o campo de pesquisa não estiver vazio, filtra os usuários pelo nome ou email
                    usuarios = usuarios.Where(u => u.Nome.Contains(textBoxUsuarioPesquisar.Text) || u.Email.Contains(textBoxUsuarioPesquisar.Text));
                }
                dataGridViewUsuarios.DataSource = usuarios.ToList(); //atribui a lista de usuários ao DataGridView
            }
        }
        private void caixaTxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios(); //chama o método de busca com o texto digitado
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0) //verifica se há uma linha selecionada
            {
                var usuarioSelecionado = dataGridViewUsuarios.SelectedRows[0].DataBoundItem as Usuario; //pega o usuário selecionado
                if (usuarioSelecionado != null)
                {
                    using (var bd = new ComandaDBContext()) //conectar ao banco de dados
                    {
                        bd.Usuarios.Remove(usuarioSelecionado); //remove o usuário selecionado do banco de dados
                        bd.SaveChanges(); //salva as alterações no banco de dados
                    }
                    BuscarUsuarios(); //atualiza a lista de usuários após a exclusão
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Verifica se a célula clicada é uma célula de dados
                if (dataGridViewUsuarios.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn)
                {
                    // Obtém o usuário selecionado
                    UsuarioSelecionado = dataGridViewUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;
                }
                else
                {
                    UsuarioSelecionado = null; // Limpa a seleção se não for uma célula de dados
                }
            }
        }
        private void textBoxUsuarioPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios(); //chama o método de busca com o texto digitado
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
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
                if (UsuarioSelecionado == null)
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
                    UsuarioSelecionado.Nome = nome;
                    UsuarioSelecionado.Email = email;
                    UsuarioSelecionado.Senha = senha;
                    banco.Usuarios.Update(UsuarioSelecionado);
                }
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Fecha o formulário após salvar
        }
    }
    public class Usuario
    {
        public int Id { get; set; } // Identificador único do usuário
        public string Nome { get; set; } // Nome do usuário
        public string Email { get; set; } // Email do usuário
        public string Senha { get; set; } // Senha do usuário
    }
    public class UsuarioSelecionado {
        public Usuario Usuario { get; set; } // Propriedade para armazenar o usuário selecionado
    }
    public class ComandaDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; } // Conjunto de usuários no banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("sua_string_de_conexao"); // Configuração da conexão com o banco de dados
        }
    }
}
