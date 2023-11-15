using Folha_Pagamento.Entidades;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_Pagamento
{
    public partial class DiaTrabalhadoControl : UserControl
    {

        List<Diatrabalhado> mes = new List<Diatrabalhado>();
        DateTime dia;
        TimeSpan horaent;
        TimeSpan horasai;

        public DiaTrabalhadoControl()
        {
            InitializeComponent();

        }

        private void btnReamover_Click(object sender, EventArgs e)
        {
            // Obtém o controle pai do controle de usuário (pode ser um formulário ou outro controle de usuário)
            Control controlePai = this.Parent;

            // Remove o controle de usuário do seu pai
            if (controlePai != null)
            {
                controlePai.Controls.Remove(this);
            }
        }

        private void txbEntrada_Leave(object sender, EventArgs e)
        {
        }
       

        private void txbEntrada_Validating(object sender, CancelEventArgs e)
        {
            if (TimeSpan.TryParse(txbEntrada.Text, out TimeSpan valorentrada))
            {

                horaent = valorentrada;
            }
            else
            {
                MessageBox.Show("insira um valor valido");
                e.Cancel = true;
               
            }
        }

        private void txbSaida_Validating(object sender, CancelEventArgs e)
        {
            
            
            if (TimeSpan.TryParse(txbSaida.Text, out TimeSpan valorsaida))
            {
                horasai = valorsaida;
                
                if (TimeSpan.TryParse(txbEntrada.Text, out TimeSpan valorentrada))
                {
                    if (valorentrada > valorsaida) 
                    {
                        MessageBox.Show("insira um valor valido (ENTRADA APOS SAIDA)");
                        e.Cancel = true;
                    }
                }


            }
            else
            {
                MessageBox.Show("insira um valor valido");
                e.Cancel = true;

            }
            

        }
    }
}
