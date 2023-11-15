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

namespace Folha_Pagamento.Forms
{
    public partial class FormCadCargo : Form
    {
        public bool TemCampoNulo()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return true; // Encontrou um TextBox vazio ou nulo
                    }
                }
                else if (control is NumericUpDown nud)
                {
                    if (nud.Value <= 0)
                    {
                        return true;
                    }
                }

            }

            return false; // Nenhum TextBox vazio ou nulo encontrado
        }
        private void LimparTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = ""; // Limpa o texto do TextBox
                }
                else if (control is MaskedTextBox maskedtextBox)
                {
                    maskedtextBox.Text = "";
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Text = ""; // Limpa o texto do TextBox
                }
            }
        }
        public FormCadCargo()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargo cargo = new Cargo();
                cargo.Nome_Cargo = txtnome.Text;
                cargo.Carga_Horaria = double.Parse(txtCargaHoraria.Value.ToString().Replace(",", "."));
                cargo.Salario_Bruto = decimal.Parse(txtSalario.Value.ToString());//.Replace(",","."));
                
                var nulo = TemCampoNulo();
                if (nulo == true)
                {
                    MessageBox.Show("campo nulo");
                }
                else
                {
                    DataAcessObject.CargoDAO.InserirCargo(cargo);

                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormCadCargo_Load(object sender, EventArgs e)
        {

        }
    }
}
