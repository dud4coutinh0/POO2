using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MultiplasTelasWindosForms
{
    public partial class ExibirCadastro : Form
    {
        //public ExibirCadastro(string nome, string telefone, string email)
        public ExibirCadastro(userDTO user)
        {
            InitializeComponent();
            //ExibeValores(nome, telefone, email);
            //ExibeValores(user.Nome, user.Telefone, user.Email);
            ExibeValores(user);
        }

        // public void ExibeValores(string nome, string telefone, string email)
        
        //{
            //lblNome.Text = nome;    
           // lblTelefone.Text = telefone;
           // lblEmail.Text = email;
        //}
    public void ExibeValores(userDTO user)
        {
            lblNome.Text = user.Nome;    
            lblTelefone.Text = user.Telefone;
            lblEmail.Text = user.Email;
        }
    }
    
}
