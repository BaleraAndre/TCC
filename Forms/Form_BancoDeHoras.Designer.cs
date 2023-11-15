namespace Folha_Pagamento.Forms
{
    partial class Form_BancoDeHoras
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Dia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.Dia3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.Entrada,
            this.Saida});
            this.dgv1.Location = new System.Drawing.Point(5, 68);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv1.Size = new System.Drawing.Size(287, 297);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv1_CellValidating);
            this.dgv1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellValueChanged);
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            // 
            // Saida
            // 
            this.Saida.HeaderText = "Saida";
            this.Saida.Name = "Saida";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 49);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 31);
            this.panel3.TabIndex = 2;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToResizeColumns = false;
            this.dgv2.AllowUserToResizeRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia2,
            this.Entrada2,
            this.Saida2});
            this.dgv2.Location = new System.Drawing.Point(295, 68);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv2.Size = new System.Drawing.Size(299, 297);
            this.dgv2.TabIndex = 3;
            this.dgv2.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellLeave);
            this.dgv2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv2_CellValidating);
            // 
            // Dia2
            // 
            this.Dia2.HeaderText = "Dia";
            this.Dia2.Name = "Dia2";
            this.Dia2.ReadOnly = true;
            // 
            // Entrada2
            // 
            this.Entrada2.HeaderText = "Entrada";
            this.Entrada2.Name = "Entrada2";
            // 
            // Saida2
            // 
            this.Saida2.HeaderText = "Saida";
            this.Saida2.Name = "Saida2";
            // 
            // dgv3
            // 
            this.dgv3.AllowUserToAddRows = false;
            this.dgv3.AllowUserToDeleteRows = false;
            this.dgv3.AllowUserToResizeColumns = false;
            this.dgv3.AllowUserToResizeRows = false;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia3,
            this.Entrada3,
            this.Saida3});
            this.dgv3.Location = new System.Drawing.Point(598, 68);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersVisible = false;
            this.dgv3.RowTemplate.Height = 25;
            this.dgv3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv3.Size = new System.Drawing.Size(287, 297);
            this.dgv3.TabIndex = 4;
            this.dgv3.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv3_CellValidating);
            // 
            // Dia3
            // 
            this.Dia3.HeaderText = "Dia";
            this.Dia3.Name = "Dia3";
            this.Dia3.ReadOnly = true;
            // 
            // Entrada3
            // 
            this.Entrada3.HeaderText = "Entrada";
            this.Entrada3.Name = "Entrada3";
            // 
            // Saida3
            // 
            this.Saida3.HeaderText = "Saida";
            this.Saida3.Name = "Saida3";
            // 
            // BtnConcluir
            // 
            this.BtnConcluir.Location = new System.Drawing.Point(713, 388);
            this.BtnConcluir.Name = "BtnConcluir";
            this.BtnConcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnConcluir.TabIndex = 5;
            this.BtnConcluir.Text = "button2";
            this.BtnConcluir.UseVisualStyleBackColor = true;
            this.BtnConcluir.Click += new System.EventHandler(this.BtnConcluir_Click);
            // 
            // Form_BancoDeHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 517);
            this.Controls.Add(this.BtnConcluir);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BancoDeHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BancoDeHoras";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgv2;
        private DataGridView dgv3;
        private DataGridViewTextBoxColumn Dia;
        private DataGridViewTextBoxColumn Entrada;
        private DataGridViewTextBoxColumn Saida;
        private DataGridViewTextBoxColumn Dia2;
        private DataGridViewTextBoxColumn Entrada2;
        private DataGridViewTextBoxColumn Saida2;
        private DataGridViewTextBoxColumn Dia3;
        private DataGridViewTextBoxColumn Entrada3;
        private DataGridViewTextBoxColumn Saida3;
        private Button button1;
        private Button BtnConcluir;
    }
}