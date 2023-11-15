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
    public partial class CadFuncionario : Form
    {

        public bool TemCampoNulo()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return true; // Encontrou um TextBox vazio ou nulo
                    }
                }
            }

            return false; // Nenhum TextBox vazio ou nulo encontrado
        }
        private void LimparTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = ""; // Limpa o texto do TextBox
                }
                else if(control is MaskedTextBox maskedtextBox)
                {
                    maskedtextBox.Text = "";
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Text = ""; // Limpa o texto do TextBox
                }
            }
        }
        public CadFuncionario()
        {
            InitializeComponent();
            List<Cargo> cargos = new List<Cargo>();
            cargos = DataAcessObject.CargoDAO.ObterTodos();
            foreach (Cargo cargo in cargos) 
            {
                txtcargo.Items.Add(cargo.Nome_Cargo);

                    }

        }

        private void CadFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
           try { 
            Funcionario funcionario = new Funcionario();
            funcionario.Nome_Completo = txtnome.Text;
            funcionario.Email = txtemail.Text;
            funcionario.Telefone = txttelefone.Text;
            funcionario.CPF = txtcpf.Text;
            funcionario.RG = txtrg.Text;
            funcionario.Orgao_Emissor = txtorgaoemissor.Text;
            funcionario.Nome_Mae = txtmae.Text;
            funcionario.Nome_Pai = txtpai.Text;
            funcionario.Data_Admissao = txtdataadmissao.Text;
            funcionario.Cargo = txtcargo.Text;
            funcionario.Pis = txtpis.Text;
            funcionario.Estado_Civil = txtestadocivil.Text;
            funcionario.Grau_Escolaridade = txtgrauescolaridade.Text;
            funcionario.Regime_Trabalhista = txtregimetrabalhista.Text;
            funcionario.Data_Nascimento = txtdatanascimento.Text;
            funcionario.Raca = txtraca.Text;
            funcionario.Sexo = txtsexo.Text;
            funcionario.Pais_Origem = txtpaisorigem.Text;
            funcionario.Senha = txtsenha.Text;
            funcionario.CEP = txtcep.Text;
            funcionario.Endereco = txtendereco.Text;
            funcionario.Numero = txtnumero.Text;
            funcionario.Complemento = txtcomplemento.Text;
            funcionario.Bairro = txtbairro.Text;
            funcionario.Cidade = txtcidade.Text;
            var nulo = TemCampoNulo();
            if (nulo == true)
            {
                MessageBox.Show("campo nulo");
            }
            else
            {
                Folha_Pagamento.DataAcessObject.FuncionarioDAO.InserirFuncionario(funcionario);

            }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            /*finally 
            {
                funcionario.Nome_Completo = txtnome.Text;
                funcionario.Email = txtemail.Text;
                funcionario.Telefone = txttelefone.Text;
                funcionario.CPF = txtcpf.Text;
                funcionario.RG = txtrg.Text;
                funcionario.Orgao_Emissor = txtorgaoemissor.Text;
                funcionario.Nome_Mae = txtmae.Text;
                funcionario.Nome_Pai = txtpai.Text;
                funcionario.Data_Admissao = txtdataadmissao.Text;
                funcionario.Cargo = txtcargo.Text;
                funcionario.Pis = txtpis.Text;
                funcionario.Estado_Civil = txtestadocivil.Text;
                funcionario.Grau_Escolaridade = txtgrauescolaridade.Text;
                funcionario.Regime_Trabalhista = txtregimetrabalhista.Text;
                funcionario.Data_Nascimento = txtdatanascimento.Text;
                funcionario.Raca = txtraca.Text;
                funcionario.Sexo = txtsexo.Text;
                funcionario.Pais_Origem = txtpaisorigem.Text;
                funcionario.Senha = txtsenha.Text;
                funcionario.CEP = txtcep.Text;
                funcionario.Endereco = txtendereco.Text;
                funcionario.Numero = txtnumero.Text;
                funcionario.Complemento = txtcomplemento.Text;
                funcionario.Bairro = txtbairro.Text;
                funcionario.Cidade = txtcidade.Text;
            }


            */
            
            
        }
    }
}
