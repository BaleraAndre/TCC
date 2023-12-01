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
    public partial class FormBuscarHolerite : Form
    {
        public FormBuscarHolerite()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtFuncionario.Text.Length == 0)
            {
                MessageBox.Show("Digite o nome e a data");
                return;
            }
            double a = 0;
            string nome = txtFuncionario.Text;
            DateTime data = dateTimePicker1.Value;
            Holerite holerite = new Holerite();
            holerite = DataAcessObject.HoleriteDAO.BuscarPorNomeEData(nome, data);
            Forms.FormHolerite form = new FormHolerite(holerite,a);
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
