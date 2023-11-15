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
    public partial class Form_MenuPrincipal : Form
    {
        public Form_MenuPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
              
        }

        private void btnCadFuncioanrio_Click(object sender, EventArgs e)
        {
            /*FormChild childForm = new FormChild();
            childForm.MdiParent = this; // Define o pai da janela secundária como o contêiner MDI (Form1)
            childForm.Show();*/
            FecharPnlPrincipal();
            FecharChilds();           
            Folha_Pagamento.Forms.FormCadFuncionario Cadfunc = new Folha_Pagamento.Forms.FormCadFuncionario();
            Cadfunc.MdiParent = this;
            Cadfunc.Show();

        }
        
        private void btnCad_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FecharPnlPrincipal();
            FecharChilds();
            Folha_Pagamento.Forms.FormReg_Funcionario form = new FormReg_Funcionario();
            form.MdiParent = this;
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnholerite_Click(object sender, EventArgs e)
        {
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FecharPnlPrincipal();
            FecharChilds();
            Forms.FormCentralDePagamento form = new FormCentralDePagamento();
            form.MdiParent = this;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FecharPnlPrincipal();
            FecharChilds();
            Folha_Pagamento.Forms.FormCadCargo form = new FormCadCargo();
            form.MdiParent = this;
            form.Show();
        }

        private void btnCadOperacao_Click(object sender, EventArgs e)
        {
            FecharPnlPrincipal();
            FecharChilds();
            Folha_Pagamento.Forms.FormCadOperacao form = new FormCadOperacao();
            form.MdiParent = this;
            form.Show();
        }

       

        private void FecharChilds()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }
        private void FecharPnlPrincipal()
        {
            if (pnlmeio.Visible == true)
            {
                pnlmeio.Visible = false;
            }
            else
            {
                pnlmeio.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.FormBuscarHolerite form = new FormBuscarHolerite();
            form.Show();
        }

        private void llinicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FecharPnlPrincipal();
            FecharChilds();

            pnlmeio.Visible = true;
        }
    }
}
