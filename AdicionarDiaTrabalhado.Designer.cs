namespace Folha_Pagamento
{
    partial class AdicionarDiaTrabalhado
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
            this.btnAdicionarDia = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.diaTrabalhadoControl1 = new Folha_Pagamento.DiaTrabalhadoControl();
            this.SuspendLayout();
            // 
            // btnAdicionarDia
            // 
            this.btnAdicionarDia.Location = new System.Drawing.Point(571, 3);
            this.btnAdicionarDia.Name = "btnAdicionarDia";
            this.btnAdicionarDia.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarDia.TabIndex = 0;
            this.btnAdicionarDia.Text = "Novo";
            this.btnAdicionarDia.UseVisualStyleBackColor = true;
            this.btnAdicionarDia.Click += new System.EventHandler(this.btnAdicionarDia_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(79, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // diaTrabalhadoControl1
            // 
            this.diaTrabalhadoControl1.AutoScroll = true;
            this.diaTrabalhadoControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.diaTrabalhadoControl1.Location = new System.Drawing.Point(0, 62);
            this.diaTrabalhadoControl1.Name = "diaTrabalhadoControl1";
            this.diaTrabalhadoControl1.Size = new System.Drawing.Size(666, 60);
            this.diaTrabalhadoControl1.TabIndex = 2;
            // 
            // AdicionarDiaTrabalhado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.diaTrabalhadoControl1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAdicionarDia);
            this.Name = "AdicionarDiaTrabalhado";
            this.Size = new System.Drawing.Size(666, 122);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdicionarDia;
        private Button btnSalvar;
        private DiaTrabalhadoControl diaTrabalhadoControl1;
    }
}
