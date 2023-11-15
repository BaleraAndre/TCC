using Folha_Pagamento.Entidades;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_Pagamento.Forms
{
    public partial class FormBancoDeHoras : Form
    {
        DateTime totalhoras;
        double horas = 0;
        string htrabalhadas = "";
        TimeSpan total = TimeSpan.Zero;
        TimeSpan tempo = TimeSpan.Zero;
        public FormBancoDeHoras()
        {
            InitializeComponent();
            


            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudAno_ValueChanged(object sender, EventArgs e)
        {
            int mesSelecionado = int.Parse(cbmes.SelectedItem.ToString());
            int anoSelecionado = (int)nudAno.Value;

            // Use DateTime para obter o último dia do mês selecionado
            DateTime primeiroDiaDoMes = new DateTime(anoSelecionado, mesSelecionado, 1);
            DateTime ultimoDiaDoMes = primeiroDiaDoMes.AddMonths(1).AddDays(-1);
            int totalDiasNoMes = ultimoDiaDoMes.Day;
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            string horaDigitada = maskedTextBox1.Text;

            if (IsValidTime(horaDigitada))
            {
                // O horário é válido
            }
            else
            {
                // O horário não é válido, mostre uma mensagem de erro ou trate de outra forma
                MessageBox.Show("Horário inválido. O formato deve ser HH:mm.");
                maskedTextBox1.Text = ""; // Limpe o campo se o valor for inválido
            }
        }
        // Função para validar o formato do horário
        private bool IsValidTime(string hora)
        {
            if (DateTime.TryParseExact(hora, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            return false;
        }

        /* private void ButtonConverter_Click(object sender, EventArgs e)
{
    string formatoHora = "HH:mm"; // Define o formato da hora (sem segundos)

    // Obtém o valor do TextBox e tenta converter para TimeSpan
    if (TimeSpan.TryParseExact(textBoxHora.Text, formatoHora, CultureInfo.InvariantCulture, out TimeSpan tempo))
    {
        // A conversão foi bem-sucedida, 'tempo' contém o valor do TimeSpan sem segundos
        // Faça algo com 'tempo', se necessário
        MessageBox.Show($"Hora convertida: {tempo.ToString(formatoHora)}");
    }
    else
    {
        // A conversão falhou, exiba uma mensagem de erro
        MessageBox.Show("Formato de hora inválido. Insira uma hora válida no formato HH:mm.");
    }
} */


        private void btnconcluir_Click(object sender, EventArgs e)
        {
            string formatoHora = "HH:mm"; // Define o formato da hora (sem segundos)
            foreach (Control controle in Controls)
            {
                // Verifica se o controle é um TextBox
                if (controle is MaskedTextBox)
                {
                    MaskedTextBox textBox = (MaskedTextBox)controle;

                    if (TimeSpan.TryParseExact(textBox.Text, "HH:mm", CultureInfo.InvariantCulture, out TimeSpan tempo))
                    {
                        // Soma o tempo ao total
                        total = total.Add(tempo);
                    }
                    else
                    {
                        // Se a conversão falhar, você pode lidar com isso conforme necessário, como exibir uma mensagem de erro.
                        MessageBox.Show($"Formato de hora inválido no TextBox {textBox.Name}. Insira um valor válido no formato HH:mm.");
                        return; // Sai da função porque há um erro de entrada
                    }
                }
            }

            MessageBox.Show(total.ToString());
        }
    }
}
