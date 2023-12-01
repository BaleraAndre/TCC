namespace Folha_Pagamento.Forms
{
    partial class FormCadOperacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label26 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtCondicao = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(74, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(293, 32);
            this.label26.TabIndex = 65;
            this.label26.Text = "CADASTRAR OPERAÇÃO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(587, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 15);
            this.label14.TabIndex = 64;
            this.label14.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 63;
            this.label8.Text = "CONDIÇÃO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "NOME DA OPERAÇÃO:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(74, 84);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(203, 23);
            this.txtnome.TabIndex = 60;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(836, 487);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(141, 61);
            this.btnsalvar.TabIndex = 66;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtCondicao
            // 
            this.txtCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCondicao.FormattingEnabled = true;
            this.txtCondicao.Items.AddRange(new object[] {
            "Desconto",
            "Acréscimo"});
            this.txtCondicao.Location = new System.Drawing.Point(331, 84);
            this.txtCondicao.Name = "txtCondicao";
            this.txtCondicao.Size = new System.Drawing.Size(209, 23);
            this.txtCondicao.TabIndex = 67;
            // 
            // txtTipo
            // 
            this.txtTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "%",
            "Valor"});
            this.txtTipo.Location = new System.Drawing.Point(587, 84);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(209, 23);
            this.txtTipo.TabIndex = 68;
            // 
            // FormCadOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 690);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCondicao);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(165, 1);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "FormCadOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCadOperacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label26;
        private Label label14;
        private Label label8;
        private Label label1;
        private TextBox txtnome;
        private Button btnsalvar;
        private ComboBox txtCondicao;
        private ComboBox txtTipo;
    }
}