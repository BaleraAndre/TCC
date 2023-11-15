using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_Pagamento.Entidades
{
    public class Diatrabalhado
    {
        public Diatrabalhado(DateTime dia, double horaentrada, double horasaida)
        {
            this.dia = dia;
            this.horaentrada = horaentrada;
            this.horasaida = horasaida;
        }

        DateTime dia { get; set; }
        double horaentrada { get; set; }
        double horasaida { get; set; }


        public override string ToString()
        {
            return $"{dia.ToString()} , {horaentrada.ToString()} , {horasaida.ToString()}";
            //return $"Nome: {Nome}, Idade: {Idade}";
        }

    }
}
