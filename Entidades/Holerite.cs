using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_Pagamento.Entidades
{
    public class Holerite
    {
        /*public Holerite(DateTime data_Emissao)
        {
            Data_Emissao = data_Emissao;
        }*/

        public DateTime Data_Emissao { get; set; }
        public DateTime Mes_Ano_Pagamento { get; set; }
        public int Id { get; set; }
        public int Id_Holerite { get; set; }
        public string Nome_Funcionario { get; set; }
        public string Cargo { get; set; }
        public DateTime Data_Adimissao_Funcionario { get; set; }
        public double Inss { get; set; }
        public double Fgts { get; set; }
        public double Desc_Dias { get; set; }
        //public double Vale_Transporte { get; set; }
        public int Dias_Trabalhados { get; set; }
        public double Salario_Bruto { get; set; }
        public double Salario_Liquido { get; set; }
        public double Horas_Trabalhadas { get; set; }
        public double Total_Desc { get; set; }




    }
}
