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
    public partial class FormReg_Cargo : Form
    {
        public FormReg_Cargo()
        {
            InitializeComponent();

            List<Cargo> listacargos = DataAcessObject.CargoDAO.ObterTodos();
            foreach (Cargo c in listacargos)
            {
                dgvcargos.Rows.Add(c.ID,c.Nome_Cargo,c.Carga_Horaria,c.Salario_Bruto);
            }
            List<Operacao> listadeoperacao = DataAcessObject.OperacaoDAO.ObterTodos();
            foreach(Operacao op in listadeoperacao)
            {
                dgvoperacoes.Rows.Add(op.ID, op.Nome_Operacao, op.Condicao, op.Tipo);
            }
        }
    }
}
