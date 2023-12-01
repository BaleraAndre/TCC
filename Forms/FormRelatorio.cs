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
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;

namespace Folha_Pagamento.Forms
{
    public partial class FormRelatorio : Form
    {


        public FormRelatorio()
        {
            InitializeComponent();
            List<Holerite> holerites = new List<Holerite>();
            holerites = DataAcessObject.HoleriteDAO.ObterTodos();
            int mesatual = int.Parse(DateTime.Now.Month.ToString());
            lblmes.Text = Mes(mesatual);
            int anoatual = DateTime.Now.Year;
            lblano.Text = anoatual.ToString();
            lblgastomes.Text = CalcularGastosMes();
            lblgastoano.Text = CalcularGastoAno();
            lblultimogasto.Text = CalcularUltimoPagamento();
            lblfuncionario.Text = NomedoUltimoPagamento();

            tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add(); tabela.Rows.Add();
            tabela.Rows[0].Cells[0].Value = "Janeiro";
            tabela.Rows[1].Cells[0].Value = "Fevereiro";
            tabela.Rows[2].Cells[0].Value = "Março";
            tabela.Rows[3].Cells[0].Value = "Abril";
            tabela.Rows[4].Cells[0].Value = "Maio";
            tabela.Rows[5].Cells[0].Value = "Junho";
            tabela.Rows[6].Cells[0].Value = "Julho";
            tabela.Rows[7].Cells[0].Value = "Agosto";
            tabela.Rows[8].Cells[0].Value = "Setembro";
            tabela.Rows[9].Cells[0].Value = "Outubro";
            tabela.Rows[10].Cells[0].Value = "Novembro";
            tabela.Rows[11].Cells[0].Value = "Dezembro";








        }



        public string NomedoUltimoPagamento()
        {
            List<Holerite> holeritesMes = new List<Holerite>();
            holeritesMes = DataAcessObject.HoleriteDAO.ObterTodos();
            DateTime data = new DateTime(2023, 1, 15);
            foreach (Holerite h in holeritesMes)
            {

                if (data < h.Data_Emissao)
                {
                    data = h.Data_Emissao;

                }

            }

            foreach (Holerite h in holeritesMes)
            {
                if (h.Data_Emissao == data)
                {
                    return h.Nome_Funcionario;
                }

            }
            return null;





        }


        public string CalcularUltimoPagamento()
        {
            List<Holerite> holeritesMes = new List<Holerite>();
            holeritesMes = DataAcessObject.HoleriteDAO.ObterTodos();
            DateTime data = new DateTime(2023, 1, 15);
            foreach (Holerite h in holeritesMes)
            {

                if (data < h.Data_Emissao)
                {
                    data = h.Data_Emissao;

                }

            }

            foreach (Holerite h in holeritesMes)
            {
                if (h.Data_Emissao == data)
                {
                    return h.Salario_Bruto.ToString() + ",00";
                }

            }
            return null;





        }

        public string CalcularGastoAno()
        {
            List<Holerite> holeritesMes = new List<Holerite>();
            holeritesMes = DataAcessObject.HoleriteDAO.ObterTodos();
            double gasto = 0;
            foreach (Holerite h in holeritesMes)
            {
                if (DateTime.Now.Year == h.Data_Emissao.Year)
                {
                    gasto = gasto + h.Salario_Bruto;

                }

            }

            return gasto.ToString() + ",00";



        }


        public string CalcularGastosMes()
        {
            List<Holerite> holeritesMes = new List<Holerite>();
            holeritesMes = DataAcessObject.HoleriteDAO.ObterTodos();
            double gasto = 0;
            foreach (Holerite h in holeritesMes)
            {
                if (DateTime.Now.Month == h.Data_Emissao.Month)
                {
                    gasto = gasto + h.Salario_Bruto;

                }

            }

            return gasto.ToString() + ",00";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Mes(int mes)
        {
            if (mes == 1)
            {
                return "Janeiro";
            }
            else if (mes == 2)
            {
                return "Fevereiro";
            }
            else if (mes == 3)
            {
                return "Março";
            }
            else if (mes == 4)
            {
                return "Abril";
            }
            else if (mes == 5)
            {
                return "Maio";
            }
            else if (mes == 6)
            {
                return "Junho";
            }
            else if (mes == 7)
            {
                return "Julho";
            }
            else if (mes == 8)
            {
                return "Agosto";
            }
            else if (mes == 9)
            {
                return "Setembro";
            }
            else if (mes == 10)
            {
                return "Outubro";
            }
            else if (mes == 11)
            {
                return "Novembro";
            }
            else
            {
                return "Dezembro";
            }
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            List<Holerite> holeritesMes = new List<Holerite>();
            holeritesMes = DataAcessObject.HoleriteDAO.ObterTodos();
            double janeiro = 0;
            double fevereiro = 0;
            double marco = 0;
            double abril = 0;
            double maio = 0;
            double junho = 0;
            double julho = 0;
            double agosto = 0;
            double setembro = 0;
            double outubro = 0;
            double novembro = 0;
            double dezembro = 0;
            foreach (Holerite h in holeritesMes)
            {
                

                if (h.Data_Emissao.Month == 1)
                {
                    janeiro = +h.Salario_Bruto;
                    tabela.Rows[0].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 2)
                {

                    tabela.Rows[1].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 3)
                {
                    tabela.Rows[2].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 4)
                {
                    tabela.Rows[3].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 5)
                {
                    tabela.Rows[4].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 6)
                {
                    tabela.Rows[5].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 7)
                {
                    tabela.Rows[6].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 8)
                {
                    tabela.Rows[7].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 9)
                {

                    tabela.Rows[8].Cells[2].Value = h.Salario_Bruto.ToString();

                }
                else if (h.Data_Emissao.Month == 10)
                {
                    outubro = outubro + h.Salario_Bruto;
                    tabela.Rows[9].Cells[2].Value = outubro.ToString() + ",00";

                }
                else if (h.Data_Emissao.Month == 11)
                {
                    novembro = novembro + h.Salario_Bruto;
                    tabela.Rows[10].Cells[2].Value = novembro.ToString()+",00";

                }
                else if (h.Data_Emissao.Month == 12)
                {
                    tabela.Rows[11].Cells[2].Value = dezembro.ToString();

                }
            }






        }
    }
}
