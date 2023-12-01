using Folha_Pagamento.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_Pagamento.Forms
{
    public partial class FormHolerite : Form
    {
        public FormHolerite(Holerite holerite , double horas)
        {
            InitializeComponent();
            //MdiParent = Forms.FormSalvarHolerite.ActiveForm;
            lbldataemissaoholerite.Text = holerite.Data_Emissao.ToShortDateString();
            lblmesano.Text = holerite.Data_Emissao.ToShortDateString();
            lblidfuncionario.Text = holerite.Id.ToString();
            lblnomefuncionario.Text = holerite.Nome_Funcionario.ToString();
            lblcargofuncionario.Text = holerite.Cargo.ToString();
            lbldataadimissaofuncionario.Text = holerite.Data_Adimissao_Funcionario.ToShortDateString();
            lblsalariobruto.Text = holerite.Salario_Bruto.ToString();
            txtsalariobruto.Text = holerite.Salario_Bruto.ToString();
            lblfgts.Text = holerite.Fgts.ToString();
            lblfgts2.Text = holerite.Fgts.ToString();
            lbldata.Text = holerite.Data_Emissao.ToShortDateString();
            lblinss.Text = holerite.Inss.ToString();
            double value = horas;
            double irrf = Regras_de_Negocio.CalcularDescontos.CalcularIRRF(holerite.Salario_Bruto);
            double valor = (horas - (irrf + holerite.Inss + holerite.Fgts));
            txtsalarioliquido.Text = valor.ToString("F2");
            //txtdescontos.Text = holerite.Inss+holerite.Fgts
            txtdescontos.Text = (irrf+holerite.Total_Desc).ToString("F2");
            
            dgvInformacoes.Rows.Add();
            dgvInformacoes.Rows.Add();
            dgvInformacoes.Rows.Add();

            dgvInformacoes.Rows[0].Cells[0].Value = "1";
            dgvInformacoes.Rows[0].Cells[1].Value = "INSS";
            dgvInformacoes.Rows[0].Cells[2].Value = "1,0";
            dgvInformacoes.Rows[0].Cells[4].Value = holerite.Inss.ToString();
            
            dgvInformacoes.Rows[1].Cells[0].Value = "2";
            dgvInformacoes.Rows[1].Cells[1].Value = "FGTS";
            dgvInformacoes.Rows[1].Cells[2].Value = "1,0";
            dgvInformacoes.Rows[1].Cells[4].Value = holerite.Fgts.ToString();
            txtdescontos.Text = (holerite.Inss+holerite.Fgts+irrf).ToString("F2");
            lblirrf.Text = irrf.ToString("F2");
            
            dgvInformacoes.Rows[2].Cells[0].Value = "3";
            dgvInformacoes.Rows[2].Cells[1].Value = "IRRF";
            dgvInformacoes.Rows[2].Cells[2].Value = "1,0";
            dgvInformacoes.Rows[2].Cells[4].Value = irrf.ToString("F2");

            dgvInformacoes.Rows[3].Cells[0].Value = "4";
            dgvInformacoes.Rows[3].Cells[1].Value = "Salario Bruto";
            dgvInformacoes.Rows[3].Cells[2].Value = "1,0";
            dgvInformacoes.Rows[3].Cells[3].Value = holerite.Salario_Bruto.ToString();




            this.Shown += FormHolerite_Shown;

        }

        

        private void FormHolerite_Shown(object? sender, EventArgs e)
        {
            this.FormBorderStyle= FormBorderStyle.None;
            
            // Cria um objeto Bitmap para armazenar a captura de tela
            Bitmap capturaTela = new Bitmap(this.Width, this.Height);

            // Usa o método DrawToBitmap para capturar o conteúdo do formulário
            this.DrawToBitmap(capturaTela, new Rectangle(0, 0, this.Width, this.Height));

            // Salva a captura de tela em um arquivo (opcional)
            capturaTela.Save("captura_tela.png", System.Drawing.Imaging.ImageFormat.Png);
            this.FormBorderStyle= FormBorderStyle.FixedToolWindow;
            // Exibe uma mensagem de sucesso (opcional)
            PrintDocument pd = new PrintDocument();

            // Associa o evento PrintPage ao método que vai lidar com a impressão
            pd.PrintPage += new PrintPageEventHandler(this.PD_PrintPage);

            // Abre a caixa de diálogo de impressão para permitir ao usuário selecionar a impressora e configurações
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Inicia o processo de impressão
                pd.Print();
            }
        }
        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            //// Lógica para desenhar o conteúdo a ser impresso, incluindo a imagem
            //Font fonte = new Font("Arial", 12);
            //string texto = "Conteúdo do formulário a ser impresso.";

            // Desenha o texto na página
            // e.Graphics.DrawString(texto, fonte, Brushes.Black, new PointF(100, 100));

            // Desenha a imagem na página
            var imagemParaImpressao = Image.FromFile("captura_tela.png");
            imagemParaImpressao.RotateFlip(RotateFlipType.Rotate270FlipNone);
            e.Graphics.DrawImage(imagemParaImpressao, new Point(10,10));
        }
    }
}
