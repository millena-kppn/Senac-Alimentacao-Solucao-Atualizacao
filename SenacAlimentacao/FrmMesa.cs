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
    public partial class FrmMesa : Form
    {
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void btnSalvarMenu_Click(object sender, EventArgs e)
        {
            // Conectar ao banco de dados
            using (var banco = new ComandaDBContext())
            {
                // Capturar os dados da tela
                int numeroMesa = int.Parse(textTituloMesa.Text);

                // Criar uma nova mesa
                var mesa = new Mesa()
                {
                    NumeroMesa = numeroMesa,
                };
                // Adicionar a mesa e salvar as alterações no banco
                banco.Mesas.Add(mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Fecha o formulário após salvar
        }

        private void btnSairMenuMesa_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário
        }
    }
}