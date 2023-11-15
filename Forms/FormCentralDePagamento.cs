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
    public partial class FormCentralDePagamento : Form
    {
        public FormCentralDePagamento()
        {
            InitializeComponent();
            List<Funcionario> funcionarios = new List<Funcionario>(Folha_Pagamento.DataAcessObject.FuncionarioDAO.ObterTodos());
            int count = funcionarios.Count;
            foreach (Funcionario func in funcionarios)
            {
                dgvreg.Rows.Add(func.ID, func.Nome_Completo);
            }

        }

        private void dgvreg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvreg.SelectedCells[0].RowIndex; // Índice da linha selecionada
            int columnIndex = dgvreg.SelectedCells[0].ColumnIndex; // Índice da coluna selecionada
            string Nome = dgvreg.Rows[rowIndex].Cells[1].Value.ToString();

            // string Nome = 

            //dgvreg.SelectedRows[0].Cells[1].Value.ToString();

            //dgvreg.SelectedRows[0].Cells[1].Value.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                
                Funcionario funcionario = Folha_Pagamento.DataAcessObject.FuncionarioDAO.ObterPorNome(Nome);
                Forms.FormHoleriteGerar form = new FormHoleriteGerar(funcionario);
                form.Show();
            }
        }
    }
}
