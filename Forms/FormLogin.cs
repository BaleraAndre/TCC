using Folha_Pagamento.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_Pagamento.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            string email = txtusername.Text;
            string senha = txtpassword.Text;
            funcionario = DataAcessObject.FuncionarioDAO.FuncionariosdoRH(email, senha);
            if (funcionario.Email == null)
            {
                MessageBox.Show("Email ou Senha invalido");
                return;

            }
            else
            {
                Forms.Form_MenuPrincipal form = new Forms.Form_MenuPrincipal();
                form.ShowDialog();
            }

        }

        private void llesqueciminhasenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.FormEsqueciMinhaSenha form = new FormEsqueciMinhaSenha();
            form.ShowDialog();
        }
    }
}
