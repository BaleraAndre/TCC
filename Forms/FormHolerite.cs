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
    public partial class FormHolerite : Form
    {
        public FormHolerite(Holerite holerite)
        {
            InitializeComponent();
            //MdiParent = Forms.FormSalvarHolerite.ActiveForm;
            lbldataemissaoholerite.Text = holerite.Data_Emissao.ToShortDateString();
            lblmesano.Text = holerite.Data_Emissao.ToShortDateString();
            lblidfuncionario.Text = holerite.Id.ToString();
            lblnomefuncionario.Text = holerite.Nome_Funcionario.ToString();
            lblcargofuncionario.Text = holerite.Cargo.ToString();
            lbldataadimissaofuncionario.Text = holerite.Data_Adimissao_Funcionario.ToShortDateString();
            lblsalariobruto.Text = holerite.Salario_Bruto.ToString();
            txtsalariobruto.Text = holerite.Salario_Bruto.ToString();
            lblfgts.Text = holerite.Fgts.ToString();
            lblfgts2.Text = holerite.Fgts.ToString();
            lbldata.Text = holerite.Data_Emissao.ToShortDateString();
            lblinss.Text = holerite.Inss.ToString();
            txtsalarioliquido.Text = holerite.Salario_Liquido.ToString();
            //txtdescontos.Text = holerite.Inss+holerite.Fgts
            txtdescontos.Text = holerite.Total_Desc.ToString();
            txtsalarioliquido.Text = (holerite.Salario_Bruto - holerite.Total_Desc).ToString();
            dgvInformacoes.Rows[0].Cells[0].Value = "1";
            dgvInformacoes.Rows[0].Cells[1].Value = "INSS";
            dgvInformacoes.Rows[0].Cells[2].Value = "1,0";
            dgvInformacoes.Rows[0].Cells[4].Value = holerite.Inss.ToString();
            dgvInformacoes.Rows.Add();
            dgvInformacoes.Rows[1].Cells[0].Value = "2";
            dgvInformacoes.Rows[0].Cells[1].Value = "FGTS";
            dgvInformacoes.Rows[0].Cells[2].Value = "1,0";
            dgvInformacoes.Rows[0].Cells[4].Value = holerite.Fgts.ToString();
            txtdescontos.Text = "770";
            txtsalarioliquido.Text = "2730";





        }
    }
}
