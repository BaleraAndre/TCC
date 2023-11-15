using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_Pagamento.Entidades
{
    public class Operacao
    {
        public int ID { get; set; }
        public string Nome_Operacao { get; set;}
        public string Condicao { get; set;}
        public string Tipo { get; set; }
    }
}
