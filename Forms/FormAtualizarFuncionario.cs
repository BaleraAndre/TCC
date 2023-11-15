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
    public partial class FormAtualizarFuncionario : Form
    {
        public FormAtualizarFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            lblID.Text = funcionario.ID.ToString();
            txtnome.Text = funcionario.Nome_Completo;
            txtemail.Text = funcionario.Email;
            txttelefone.Text = funcionario.Telefone;
            txtcpf.Text = funcionario.CPF;
            txtrg.Text = funcionario.RG;
            txtorgaoemissor.Text = funcionario.Orgao_Emissor;
            txtmae.Text = funcionario.Nome_Mae;
            txtpai.Text = funcionario.Nome_Pai;
            txtdataadmissao.Text = funcionario.Data_Admissao;
            txtcargo.Text = funcionario.Cargo;
            txtpis.Text = funcionario.Pis;
            txtestadocivil.Text = funcionario.Estado_Civil;
            txtgrauescolaridade.Text = funcionario.Grau_Escolaridade;
            txtregimetrabalhista.Text = funcionario.Regime_Trabalhista;
            txtdatanascimento.Text = funcionario.Data_Nascimento;
            txtraca.Text = funcionario.Raca;
            txtsexo.Text = funcionario.Sexo;
            txtpaisorigem.Text = funcionario.Pais_Origem;
            txtsenha.Text = funcionario.Senha;
            txtcep.Text = funcionario.CEP;
            txtendereco.Text = funcionario.Endereco;
            txtnumero.Text = funcionario.Numero;
            txtcomplemento.Text = funcionario.Complemento;
            txtbairro.Text = funcionario.Bairro;
            txtcidade.Text = funcionario.Cidade;

        }
    }
}
