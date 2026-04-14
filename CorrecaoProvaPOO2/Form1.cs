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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Os campos são obrigatórios");
                return;
            }
            //if (txtNome.Text.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase);
            if (txtNome.Text.Trim().Equals("Admin") && txtSenha.Text.Trim().Equals("Admin"))
            {
                Cadastro cadastro = new Cadastro();
                //this.Hide(); EXPANDE A TELA DE CADASTRO
                cadastro.Show();
            }
            else
            {
                MessageBox.Show("Senha ou user incorretos");
            }
        }
    }
}
