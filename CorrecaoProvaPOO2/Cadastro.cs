using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplasTelasWindosForms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            userDTO user = new userDTO
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };

            // ExibirCadastro exibirCadastro = new ExibirCadastro(txtNome.Text, txtTelefone.Text, txtEmail.Text); 
            // exibirCadastro.Show();
            ExibirCadastro exibirCadastro = new ExibirCadastro(user);
            exibirCadastro.Show();
        }
    }
}
