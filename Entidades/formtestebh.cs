using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_Pagamento.Entidades
{
    public partial class formtestebh : Form
    {

        private bool VerificarSeTodasAsCelulasContemTimeSpan(DataGridView dataGridView)
        {
            foreach (DataGridViewRow linha in dataGridView.Rows)
            {
                foreach (DataGridViewCell celula in linha.Cells)
                {
                    if (celula.ColumnIndex > 0)
                    {
                        // Verifica se a célula contém um valor não nulo e se pode ser convertido para TimeSpan
                        if (celula.Value != null && !string.IsNullOrWhiteSpace(celula.Value.ToString()))
                        {
                            // Tenta converter o valor da célula para TimeSpan
                            if (!TimeSpan.TryParseExact(celula.Value.ToString(), "HH:mm", CultureInfo.InvariantCulture, out TimeSpan tempo))
                            {
                                // Se a conversão falhar, a célula não contém um valor TimeSpan válido
                                MessageBox.Show("Valor inválido para data. Insira uma Hora válida (HH/MM).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            // Se a célula estiver vazia, você pode decidir se deve considerar isso como válido ou não
                            // Neste exemplo, estamos considerando um valor vazio como inválido
                            MessageBox.Show("Valor inválido para data. Insira uma Hora válida (HH/MM).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }

            // Todas as células contêm valores TimeSpan válidos
            MessageBox.Show("Valor Valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        public formtestebh()
        {
            InitializeComponent();

            for (int i = 1; i <= 10; i++)
            {
                dgv1.Rows.Add(i, " ", " ");
                int celula = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConcluir_Click(object sender, EventArgs e)
        {
            /*
            foreach (DataGridViewRow linha in dgv1.Rows)
            {
                foreach (DataGridViewCell celula in linha.Cells)
                {
                    if (celula.ColumnIndex > 0)
                    {
                        if (celula.Value != null && !string.IsNullOrEmpty(celula.Value.ToString()))
                        {
                            if (!VerificarSeHoraValida(celula.Value.ToString()))
                            {
                                // Se a célula não contiver uma hora válida, você pode lidar com isso aqui.
                                // Por exemplo, destacar a célula ou exibir uma mensagem de erro.
                                celula.Style.BackColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                }*/
            bool deucerto = VerificarSeTodasAsCelulasContemTimeSpan(dgv1);
        
    







        }
        private bool VerificarSeHoraValida(string valor)
        {
            // Define os formatos de hora aceitáveis
            string[] formatosHora = { "HH:mm:ss", "H:mm:ss", "HH:mm", "H:mm" };

            // Tenta fazer o parse da hora no formato especificado
            DateTime dataHora;
            if (DateTime.TryParseExact(valor, formatosHora, null, System.Globalization.DateTimeStyles.None, out dataHora))
            {
                // O valor é uma hora válida
                return true;
            }
            else
            {
                // O valor não é uma hora válida
                return false;
            }
        }
    }

}
