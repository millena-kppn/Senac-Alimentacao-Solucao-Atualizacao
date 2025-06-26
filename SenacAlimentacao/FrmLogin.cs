namespace SenacAlimentacao
{
    public partial class FrmLogin : Form
    {
        string nomeTela;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e) 
        {
            bool loginValido = ValidarLogin(txtLogin.Text, txtSenha.Text);
            //se o login for v�lido ele exibe o formul�rio principal
            if (loginValido == true)
                {
                    //ocultar o formul�rio FrmLogin
                    this.Hide();
                    //criar uma inst�ncia do formul�rio FrmPrincipal
                    //var frmPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                var frmPrincipal = new FrmPrincipal(nomeTela, txtSenha.Text);
                //exibir o formul�rio FrmPrincipal
                frmPrincipal.Show();
                }
        }
        

        private bool ValidarLogin(string nome, string senha)
        {

            bool usuarioValido = false;
            // CONECTA NO BANCO
            using (var banco = new ComandaDBContext())
            {
                // CONSULTAR A TABELA USUARIO SELECT * FROM USUARIOS WHERE EMAIL = ? AND SENHA = ?
                var usuario = banco
                               .Usuarios
                               .FirstOrDefault(u => u.Email == nome.ToLower() && u.Senha == senha);
                if (usuario is not null)
                    usuarioValido = true;
                nomeTela = usuario.Nome; // armazena o nome do usu�rio para exibir na tela principal

            }

            // SE nome � igual a admin E senha � igual a 123
            if (usuarioValido)
            {   // RETURNA verdadeiro
                return true;
            }
            else
            {   // EXIBE uma mensagem de erro
                MessageBox.Show("Login ou Senha inv�lidos");
            } // RETORNA false
            return false;
        }

        private void btnFecharLogin_Click(object sender, EventArgs e)
        {
            //fecha a tela de login
            Close();
            //encerra o aplicativo
            Application.Exit();
        }
    }
}
