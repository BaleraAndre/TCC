using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_Pagamento.Entidades
{
  public class Cargo
    {
        public int ID { get; set; }
       
        public string Nome_Cargo { get; set; }
       
        public double Carga_Horaria { get; set; }

        public decimal Salario_Bruto { get; set; }

    }
}
