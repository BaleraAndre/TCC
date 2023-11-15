using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_Pagamento.Forms
{
    public partial class Form_BancoDeHoras : Form
    {
        public Form_BancoDeHoras()
        {
            InitializeComponent();

            for (int i = 1; i <= 10; i++)
            {
                dgv1.Rows.Add(i, " ", " ");
                int celula = 0;

                // dgv1.Rows[i].Cells[celula+1].ReadOnly = false;

                //dgv1.Rows[i].Cells[i].Value = i;

            }
            for (int i = 11; i <= 20; i++)
            {
                dgv2.Rows.Add(i, " ", " ");
                //dgv1.Rows[i].Cells[i].Value = i;

            }
            for (int i = 21; i <= 30; i++)
            {
                dgv3.Rows.Add(i, " ", " ");

                //dgv1.Rows[i].Cells[i].Value = i;

            }

            

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





        private void ChecarValores()
        {
            for (int i = 1; i <= 10; i++)
            {
                dgv1.Rows[i].Cells[i + 1].Value = i;
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {







        }

        private void dgv2_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if(dgv2.)
        }

        private void dgv2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string valorCelula = e.FormattedValue.ToString();

                
                DateTime data;
                if (!DateTime.TryParse(valorCelula, out data))
                {
                    
                    e.Cancel = true; // nao deixar o foco sair da celula
                    MessageBox.Show("Valor inválido para data. Insira uma Hora válida (HH/MM).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string valorCelula = e.FormattedValue.ToString();
                
                DateTime data;
                if (!DateTime.TryParse(valorCelula, out data))
                {
                    
                    e.Cancel = true;  // nao deixar o foco sair da celula
                    MessageBox.Show("Valor inválido para data. Insira uma Hora válida (HH/MM).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string valorCelula = e.FormattedValue.ToString();

                
                DateTime data;
                if (!DateTime.TryParse(valorCelula, out data))
                {
                    
                    e.Cancel = true; // nao deixar o foco sair da celula
                    MessageBox.Show("Valor inválido para data. Insira uma Hora válida (HH/MM).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConcluir_Click(object sender, EventArgs e)
        {
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
                }
            }
        }
    }
}
