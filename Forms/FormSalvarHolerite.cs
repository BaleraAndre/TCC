using Folha_Pagamento.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Document = iText.Layout.Document;
using System.IO;

namespace Folha_Pagamento.Forms
{
    public partial class FormSalvarHolerite : Form
    {
        public Entidades.Holerite h = new Entidades.Holerite();
        public FormSalvarHolerite(Entidades.Holerite holerite)
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.WindowState = FormWindowState.Minimized;

            h = holerite;




        }

        private void FormSalvarHolerite_Load(object sender, EventArgs e)
        {
            Forms.FormHolerite form = new FormHolerite(h);
            form.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Salvar como PDF";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                PdfWriter writer = new PdfWriter(filePath);
                
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Adicione conteúdo ao documento PDF aqui
                        document.Add(new Paragraph("Conteúdo do seu formulário aqui"));

                        // Feche o documento
                        document.Close();
                    }
                

                MessageBox.Show("Formulário salvo como PDF com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

