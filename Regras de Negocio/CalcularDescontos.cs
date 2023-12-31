﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_Pagamento.Regras_de_Negocio
{
    public static class CalcularDescontos
    {
        
        public static double CalcularInss(Double salario )
        {
            double desconto;
            if(salario >= 0.00 && salario <= 1110.00)
            {
                desconto = salario*0.075;
                return desconto;
            }
            else if (salario >= 1110.11 && salario <= 2203.48)
            {
                desconto = salario * 0.09;
                return desconto;
            }
            else if(salario >= 2203.49 && salario <= 3305.22)
            {
                desconto = salario * 0.12;
                return desconto;
            }
            else
            {
                desconto = salario * 0.14;
                return desconto;
            }
        }

        public static double CalcularFgts(double salario)
        {
            double desconto;
            desconto = salario * 0.08;
            return desconto;
        }

        public static double CalcularIRRF(double salarioBruto)
        {
            // Definindo as faixas de renda e as respectivas alíquotas
            double[] faixas = { 1903.98, 2826.65, 3751.05, 4664.68 };
            double[] aliquotas = { 0.0, 0.075, 0.15, 0.225, 0.275 };

            // Calculando o valor do imposto de renda
            double imposto = 0.0;
            double salarioBase = salarioBruto;

            for (int i = 0; i < faixas.Length; i++)
            {
                if (salarioBase <= faixas[i])
                {
                    imposto += salarioBase * aliquotas[i];
                    break;
                }
                else
                {
                    imposto += faixas[i] * aliquotas[i];
                    salarioBase -= faixas[i];
                }
            }

            return imposto;
        }

        public static double CalcularHorasTrabalhadas(double SalarioB, double Horastrabalhadas, double CargaHoraria)
        {
            
            
            
            
            double TotalReceber = SalarioB / CargaHoraria;
            TotalReceber = TotalReceber * Horastrabalhadas;
           
            return TotalReceber;

        }






    }
}
