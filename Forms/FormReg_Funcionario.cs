using Folha_Pagamento.Entidades;
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

namespace Folha_Pagamento.Forms
{
    public partial class FormReg_Funcionario : Form
    {
        public List<Funcionario> funcionarios = new List<Funcionario>(Folha_Pagamento.DataAcessObject.FuncionarioDAO.ObterTodos());
        public FormReg_Funcionario()
        {
            InitializeComponent();                     
            var horizontalScrollBar = dgvreg.Controls.OfType<HScrollBar>().FirstOrDefault();
        }

        private void FormReg_Funcionario_Load(object sender, EventArgs e)
        {
        }

        private void dgvreg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dgvreg.Rows[e.RowIndex];
                Funcionario a = new Funcionario();
                a.ID = Convert.ToInt32(row.Cells["ID"].Value);
                a.Nome_Completo = row.Cells["Nome"].Value.ToString();
                a.Email = row.Cells["Email"].Value.ToString();
                a.Telefone = row.Cells["Telefone"].Value.ToString();
                a.CPF = row.Cells["CPF"].Value.ToString();
                a.RG = row.Cells["RG"].Value.ToString();
                a.Orgao_Emissor = row.Cells["Orgao_Emissor"].Value.ToString();
                a.Nome_Mae = row.Cells["Nome_Mae"].Value.ToString();
                a.Nome_Pai = row.Cells["Nome_Pai"].Value.ToString();
                a.Data_Admissao = row.Cells["Data_Admissao"].Value.ToString();
                a.Cargo = row.Cells["Cargo"].Value.ToString();
                a.Pis = row.Cells["PIS"].Value.ToString();
                a.Estado_Civil = row.Cells["Estado_Civil"].Value.ToString();
                a.Grau_Escolaridade = row.Cells["Grau_Escolaridade"].Value.ToString();
                a.Regime_Trabalhista = row.Cells["Regime_Trabalhista"].Value.ToString();
                a.Data_Nascimento = row.Cells["Data_Nascimento"].Value.ToString();
                a.Raca = row.Cells["Raca"].Value.ToString();
                a.Sexo = row.Cells["Sexo"].Value.ToString();
                a.Pais_Origem = row.Cells["Pais_Origem"].Value.ToString();               
                a.CEP = row.Cells["CEP"].Value.ToString();
                a.Endereco = row.Cells["Endereco"].Value.ToString();
                a.Numero = row.Cells["Numero"].Value.ToString();
                a.Complemento = row.Cells["Complemento"].Value.ToString();
                a.Bairro = row.Cells["Bairro"].Value.ToString();
                a.Cidade = row.Cells["Cidade"].Value.ToString();

                Forms.FormAtualizarFuncionario form = new FormAtualizarFuncionario(a);
                form.ShowDialog();
               
            }


        }

        private void btnbuscartodos_Click(object sender, EventArgs e)
        {
            int count = funcionarios.Count;
            foreach (Funcionario func in funcionarios)
            {
                dgvreg.Rows.Add(func.ID, func.Nome_Completo, func.Email, func.Telefone, func.CPF, func.RG, func.Orgao_Emissor,
                    func.Nome_Mae, func.Nome_Pai, func.Data_Admissao, func.Cargo, func.Pis, func.Estado_Civil, func.Grau_Escolaridade, func.Regime_Trabalhista,
                    func.Data_Nascimento, func.Raca, func.Sexo, func.Pais_Origem, func.CEP, func.Endereco, func.Numero, func.Complemento,
                    func.Bairro, func.Cidade
                    );
            }

        }
    }
}

