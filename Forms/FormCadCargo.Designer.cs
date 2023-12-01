namespace Folha_Pagamento.Forms
{
    partial class FormCadCargo
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
            this.txtSalario = new System.Windows.Forms.NumericUpDown();
            this.txtCargaHoraria = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaHoraria)).BeginInit();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(67, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(247, 32);
            this.label26.TabIndex = 58;
            this.label26.Text = "CADASTRAR CARGO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(584, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 15);
            this.label14.TabIndex = 57;
            this.label14.Text = "SALÁRIO BRUTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "CARGA HORÁRIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "NOME DO CARGO:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(67, 84);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(203, 23);
            this.txtnome.TabIndex = 53;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(838, 485);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(157, 61);
            this.btnsalvar.TabIndex = 59;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.DecimalPlaces = 2;
            this.txtSalario.Location = new System.Drawing.Point(584, 84);
            this.txtSalario.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(214, 23);
            this.txtSalario.TabIndex = 60;
            this.txtSalario.ThousandsSeparator = true;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(324, 85);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(214, 23);
            this.txtCargaHoraria.TabIndex = 61;
            // 
            // FormCadCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 619);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(165, 1);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "FormCadCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCadCargo";
            this.Load += new System.EventHandler(this.FormCadCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaHoraria)).EndInit();
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
        private NumericUpDown txtSalario;
        private NumericUpDown txtCargaHoraria;
    }
}