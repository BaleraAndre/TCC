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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Folha_Pagamento.Forms
{
    public partial class FormHoleriteGerar : Form
    { 
        public Funcionario f = new Funcionario();
        public Cargo c = new Cargo();
        public Holerite h = new Holerite();
        public Cargo cargo = new Cargo();
        
        public FormHoleriteGerar(Funcionario func)
        {


            InitializeComponent();
            f = func;
            cargo = DataAcessObject.CargoDAO.ObterPorNome(func.Cargo);





            decimal SALARIOB = cargo.Salario_Bruto;


            c = cargo;

            double Inss = Regras_de_Negocio.CalcularDescontos.CalcularInss(double.Parse(SALARIOB.ToString("F2")));
            double Fgts = Regras_de_Negocio.CalcularDescontos.CalcularFgts(double.Parse(SALARIOB.ToString("F2")));
            double salarioL = double.Parse(cargo.Salario_Bruto.ToString("F2")) - Inss - Fgts;
            object[] newRow = new object[] { "Salário Bruto:", cargo.Salario_Bruto.ToString("F2") };
            object[] newRow2 = new object[] { "Salário Liquido:", salarioL.ToString("F2") };


            dgvsalario.Rows.Add(newRow);
            dgvsalario.Rows.Add(newRow2);
            List<Operacao> operacoes = new List<Operacao>();
            operacoes = DataAcessObject.OperacaoDAO.ObterTodos();
            int qnt = operacoes.Count();

            

            foreach (Operacao operacao in operacoes)
            {
                dgvOperacoes.Rows.Add("", operacao.ID, operacao.Nome_Operacao, operacao.Condicao, operacao.Tipo, "");
                dgvValor.Rows.Add();
                if (qnt >= dgvValor.Rows.Count)
                {

                   
                    
                    if (operacao.Condicao.Equals("Desconto"))
                    {
                        dgvValor.Rows[0].Cells[0].Value = Inss.ToString("F2");
                        dgvValor.Rows.Add();
                        dgvValor.Rows[1].Cells[0].Value = Fgts.ToString("F2");
                    }
                }

            }

            //string nome = func.Nome_Completo.ToString();
            string cargoo = func.Cargo.ToString();
            //string cargahoraria;

            dgvBancodehoras.Rows.Add(cargoo , cargo.Carga_Horaria, "" , "" );

        }

        private void MontarHolerite()
        {
            h.Data_Emissao = DateTime.Now;
            h.Mes_Ano_Pagamento= DateTime.Now;
            h.Id = f.ID;
            h.Nome_Funcionario = f.Nome_Completo;
            h.Cargo = f.Cargo;
            h.Data_Adimissao_Funcionario = DateTime.Parse(f.Data_Admissao);
            h.Inss = double.Parse(dgvValor.Rows[0].Cells[0].ToString());
            h.Fgts = double.Parse(dgvValor.Rows[1].Cells[0].Value.ToString());
            h.Salario_Bruto = double.Parse(c.Salario_Bruto.ToString());
            h.Salario_Liquido = double.Parse(dgvsalario.Rows[1].Cells[1].Value.ToString());
            h.Horas_Trabalhadas = double.Parse(dgvBancodehoras.Rows[0].Cells[2].Value.ToString());
            double desDias = double.Parse(dgvBancodehoras.Rows[0].Cells[2].Value.ToString());
            double sl = h.Salario_Liquido- Regras_de_Negocio.CalcularDescontos.CalcularHorasTrabalhadas(h.Salario_Bruto,h.Horas_Trabalhadas,c.Carga_Horaria);
            h.Salario_Liquido = h.Salario_Liquido - sl;
            h.Horas_Trabalhadas = double.Parse(dgvBancodehoras.Rows[0].Cells[2].Value.ToString());

            //sl = CalcularHoras.Calcular(h.Salario_Bruto, );



        }

        private void FormHoleriteGerar_Load(object sender, EventArgs e)
        {
            dgvsalario.CellFormatting += dgvsalario_CellFormatting;
        }



        private void dgvsalario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se é uma célula da coluna "Column1" (a primeira coluna)
            if (e.ColumnIndex == 0)
            {
                // Define o alinhamento à esquerda para a célula
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            // Verifica se é uma célula da coluna "Column2" (a segunda coluna)
            else if (e.ColumnIndex == 1)
            {
                // Define o alinhamento à direita para a célula
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            double horas = double.Parse(dgvBancodehoras.Rows[0].Cells[2].Value.ToString());
            if (horas <= 0)
            {
                MessageBox.Show("Insira a carga horaria");
                return;
            }

            double salarioBruto = double.Parse(dgvsalario.Rows[0].Cells[1].Value.ToString());
            double CargaHoraria = double.Parse(dgvBancodehoras.Rows[0].Cells[1].Value.ToString());
            // MessageBox.Show($"{CHoraria - horas} , horas");
            double receber = Regras_de_Negocio.CalcularDescontos.CalcularHorasTrabalhadas(salarioBruto, horas, CargaHoraria);
            //CalcularHoras();


            Holerite holerite = new Holerite();
            holerite = RegistrarHolerite();

            
            Folha_Pagamento.Forms.FormSalvarHolerite form = new FormSalvarHolerite(holerite);
            form.ShowDialog();

           // Folha_Pagamento.Forms.FormHolerite form = new Folha_Pagamento.Forms.FormHolerite(holerite);
           // form.ShowDialog();

        }
        public Holerite RegistrarHolerite()
        {
            Holerite holerite = new Holerite();

            //holerite.Salario_Liquido = 
            double horas = double.Parse(dgvBancodehoras.Rows[0].Cells[2].Value.ToString());
            double salarioBruto = double.Parse(dgvsalario.Rows[0].Cells[1].Value.ToString());
            double CargaHoraria = double.Parse(dgvBancodehoras.Rows[0].Cells[1].Value.ToString());
            // MessageBox.Show($"{CHoraria - horas} , horas");
            double receber = Regras_de_Negocio.CalcularDescontos.CalcularHorasTrabalhadas(salarioBruto,horas,CargaHoraria);
            double sliquido = double.Parse(dgvsalario.Rows[1].Cells[1].Value.ToString());
            //CalcularHoras();
            //holerite.Salario_Liquido = double.Parse(dgvsalario.Rows[1].Cells[1].Value.ToString());
            holerite.Salario_Liquido = sliquido - receber;
            holerite.Data_Emissao = DateTime.Now;
            holerite.Mes_Ano_Pagamento = DateTime.Now;
            holerite.Id = f.ID;
            holerite.Nome_Funcionario = f.Nome_Completo;
            holerite.Cargo = f.Cargo;
            holerite.Data_Adimissao_Funcionario = DateTime.Parse(f.Data_Admissao);
            holerite.Inss = double.Parse(dgvValor.Rows[0].Cells[0].Value.ToString());
            holerite.Fgts = double.Parse(dgvValor.Rows[1].Cells[0].Value.ToString());
            holerite.Salario_Liquido = receber;
            holerite.Salario_Bruto = salarioBruto;
            holerite.Desc_Dias = Regras_de_Negocio.CalcularDescontos.CalcularHorasTrabalhadas(salarioBruto, horas, CargaHoraria);
            holerite.Dias_Trabalhados = int.Parse(dgvBancodehoras.Rows[0].Cells[3].Value.ToString());
            holerite.Horas_Trabalhadas = horas;
            holerite.Total_Desc = holerite.Fgts * holerite.Desc_Dias + holerite.Inss;
            //bool Confirma = DataAcessObject.HoleriteDAO.InserirHolerite(holerite);
            
            //holerite.Salario_Liquido = holerite.Salario_Liquido - 
           




            return holerite;


        }


        private void dgvValor_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0) // Substitua "suaColunaNumeroIndex" pelo índice da coluna onde você deseja aceitar apenas números.
            {
                string valor = e.FormattedValue.ToString();

                // Verifique se o valor é numérico
                if (!IsNumeric(valor))
                {
                    MessageBox.Show("Apenas números são permitidos nesta célula.");
                    e.Cancel = true; // Cancela a edição se o valor não for numérico.
                }
            }
        }

        private bool IsNumeric(string valor)
        {
            double numero;
            return double.TryParse(valor, out numero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Folha_Pagamento.Forms.FormBH form = new FormBH();
            form.ShowDialog();
        }

        private double CalcularHoras()
        {
            double horastrabalhadas;
            double cargahoraria = double.Parse(this.dgvBancodehoras.Rows[0].Cells[1].Value.ToString());
            double horas;
            horastrabalhadas = double.Parse(this.dgvBancodehoras.Rows[0].Cells[2].Value.ToString());
            horas = cargahoraria - horastrabalhadas;
            return horas;
        }

       
    }
}
