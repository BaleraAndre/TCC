using Folha_Pagamento.Entidades;
using iText.StyledXmlParser.Jsoup.Nodes;
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
    public partial class FormCadFuncionario : Form
    {
        public FormCadFuncionario()
        {
            InitializeComponent();
            List<Cargo> listacargos = DataAcessObject.CargoDAO.ObterTodos();
            foreach (Cargo car in listacargos)
            {
                cbcargo.Items.Add(car.Nome_Cargo);
            }

        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            if (VerificarControlesNulos(this))
            {

                //MessageBox.Show("Todos os controles estão preenchidos.");
                Funcionario funcionario = new Funcionario();
                funcionario.Nome_Completo = txtNome.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.Telefone = txtTelefone1.Text;
                funcionario.CPF = txtCpf.Text;
                funcionario.RG = txtRg.Text;
                funcionario.Orgao_Emissor = txtOrgaoemissor.Text;
                funcionario.Nome_Mae = txtNomedamae.Text;
                funcionario.Nome_Pai = txtNomedopai.Text;
                funcionario.Data_Admissao = txtDatadeadimissao.Text;
                funcionario.Cargo = cbcargo.Text;
                funcionario.Pis = txtPis.Text;
                funcionario.Estado_Civil = cbEstadocivil.Text;
                funcionario.Grau_Escolaridade = cbGrauEscolaridade.Text;
                funcionario.Regime_Trabalhista = cbRegimetrabalhista.Text;
                funcionario.Data_Nascimento = txtDatadenascimento.Text;
                funcionario.Raca = cbCor.Text;
                funcionario.Sexo = txtsexo.Text;
                funcionario.Pais_Origem = txtPaisdeorigem.Text;
                funcionario.Senha = txtSenha.Text;
                funcionario.CEP = txtCep.Text;
                funcionario.Endereco = txtEndereco.Text;
                funcionario.Numero = txtNumero.Text;
                funcionario.Complemento = txtComplemento.Text;
                funcionario.Bairro = txtBairro.Text;
                funcionario.Cidade = txtCidade.Text;
                DataAcessObject.FuncionarioDAO.InserirFuncionario(funcionario);

            }
            else
            {
                MessageBox.Show("Controles nulos.");
            }
        }
        private bool VerificarControlesNulos(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)control).Text))
                    {
                        return false;
                    }
                }
                else if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == -1)
                    {
                        return false;
                    }
                }
                else if (control is DateTimePicker)
                {
                    // Verifique conforme necessário para outros tipos de controles
                }
                // Adicione mais verificações para outros tipos de controles conforme necessário

                // Verifique recursivamente os controles nos controles do contêiner
                if (control.HasChildren)
                {
                    if (!VerificarControlesNulos(control))
                    {
                        return false;
                    }
                }
            }

            return true;
        }


    }
}

