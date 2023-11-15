namespace Folha_Pagamento
{
    partial class DiaTrabalhadoControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSaida = new System.Windows.Forms.MaskedTextBox();
            this.txbEntrada = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 2);
            this.panel1.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemover.Location = new System.Drawing.Point(579, 11);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(36, 34);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "X";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnReamover_Click);
            // 
            // dtpData
            // 
            this.dtpData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(3, 22);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(208, 23);
            this.dtpData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(235, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Entrada:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(405, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saida:";
            // 
            // txbSaida
            // 
            this.txbSaida.Location = new System.Drawing.Point(449, 25);
            this.txbSaida.Mask = "00:00";
            this.txbSaida.Name = "txbSaida";
            this.txbSaida.Size = new System.Drawing.Size(100, 23);
            this.txbSaida.TabIndex = 9;
            this.txbSaida.ValidatingType = typeof(System.DateTime);
            this.txbSaida.Validating += new System.ComponentModel.CancelEventHandler(this.txbSaida_Validating);
            // 
            // txbEntrada
            // 
            this.txbEntrada.Location = new System.Drawing.Point(291, 25);
            this.txbEntrada.Mask = "00:00";
            this.txbEntrada.Name = "txbEntrada";
            this.txbEntrada.Size = new System.Drawing.Size(100, 23);
            this.txbEntrada.TabIndex = 8;
            this.txbEntrada.ValidatingType = typeof(System.DateTime);
            this.txbEntrada.Leave += new System.EventHandler(this.txbEntrada_Leave);
            this.txbEntrada.Validating += new System.ComponentModel.CancelEventHandler(this.txbEntrada_Validating);
            // 
            // DiaTrabalhadoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.txbSaida);
            this.Controls.Add(this.txbEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.panel1);
            this.Name = "DiaTrabalhadoControl";
            this.Size = new System.Drawing.Size(636, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnRemover;
        private DateTimePicker dtpData;
        private Label label1;
        private Label label2;
        private MaskedTextBox txbSaida;
        private MaskedTextBox txbEntrada;
    }
}
