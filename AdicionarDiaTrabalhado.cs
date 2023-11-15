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

namespace Folha_Pagamento
{
    public partial class AdicionarDiaTrabalhado : UserControl
    {

        public AdicionarDiaTrabalhado()
        {
            InitializeComponent();

        }

        private void AdicionarNovoComponente()
        {
            int quantidade = 0;
            foreach (Control c in this.Controls)
            {
                if (c is DiaTrabalhadoControl)
                {
                    quantidade++;
                }
            }


            if (quantidade == 31)
            {
                MessageBox.Show("erro");
                return;
            }

            DiaTrabalhadoControl dia = new DiaTrabalhadoControl();
            dia.Dock = DockStyle.Bottom;
            // Lógica para adicionar um novo componente ao controle
            // Por exemplo, adicionar um TextBox ao controle de usuário


            // Adiciona o novo componente ao controle de usuário
            this.Controls.Add(dia);

        }



        private void btnAdicionarDia_Click(object sender, EventArgs e)
        {
            AdicionarNovoComponente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<DateTime> lista = new List<DateTime>();
            DateTime data = new DateTime(2023, 10, 15);

            int quantidade = 0;
            foreach (Control c in this.Controls)
            {

               


                if (c is DiaTrabalhadoControl)
                {
                    data = DateTime.Parse(Controls["DiaTrabalhadoControl"].Controls["dtpData"].Text);

                    // Verifica se a lista já contém a data que você deseja adicionar
                    if (lista.Contains(data))
                    {
                        MessageBox.Show("Data repetida");
                        return;
                    }
                    else
                    {
                        // Se a data não existe na lista, você pode adicioná-la
                        lista.Add(data);

                    }




                    quantidade++;
                }
            }


            if (quantidade == 0)
            {
                MessageBox.Show("funcionario nao trabalhou esse mes?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }





            else
            {
                TimeSpan totalSaida = new TimeSpan(0, 0, 0);


                for (int i = 0; i < quantidade; i++)
                {

                    // Suponha que seus controles de usuário tenham nomes como "usuarioControl1", "usuarioControl2", etc.
                    string entradaTexto = Controls["DiaTrabalhadoControl"].Controls["txbEntrada"].Text;
                    string saidaTexto = Controls["DiaTrabalhadoControl"].Controls["txbSaida"].Text;
                    totalSaida += TimeSpan.Parse(saidaTexto) - TimeSpan.Parse(entradaTexto);
                    // Verifica se os campos de entrada e saída estão preenchidos
                    /*if (!string.IsNullOrEmpty(entradaTexto) && !string.IsNullOrEmpty(saidaTexto))
                    {
                        TimeSpan entrada = TimeSpan.Parse(entradaTexto);
                        TimeSpan saida = TimeSpan.Parse(saidaTexto);
                        totalSaida += (saida - entrada);
                    }*/
                }

                // Agora 'totalSaida' contém a soma das saídas subtraindo as entradas para os 31 controles de usuário.
                MessageBox.Show("Total de horas trabalhadas: " + totalSaida);
            }
        }
    }
}
