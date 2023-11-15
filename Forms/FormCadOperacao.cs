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
    public partial class FormCadOperacao : Form
    {
        public FormCadOperacao()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Operacao operacao= new Operacao();
            operacao.Nome_Operacao = txtnome.Text;
            operacao.Condicao = txtCondicao.Text;
            operacao.Tipo = txtTipo.Text;
            DataAcessObject.OperacaoDAO.InserirOperacao(operacao);

        }
    }
}
