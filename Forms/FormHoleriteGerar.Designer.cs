namespace Folha_Pagamento.Forms
{
    partial class FormHoleriteGerar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOperacoes = new System.Windows.Forms.DataGridView();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvValor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsalario = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dgvBancodehoras = new System.Windows.Forms.DataGridView();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargahorarioacumprir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalhorastrabalhadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacoes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancodehoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperacoes
            // 
            this.dgvOperacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOperacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOperacoes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOperacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOperacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RG,
            this.ID,
            this.Nome,
            this.Email,
            this.Telefone,
            this.CPF});
            this.dgvOperacoes.EnableHeadersVisualStyles = false;
            this.dgvOperacoes.Location = new System.Drawing.Point(3, 102);
            this.dgvOperacoes.Name = "dgvOperacoes";
            this.dgvOperacoes.RowHeadersVisible = false;
            this.dgvOperacoes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOperacoes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvOperacoes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvOperacoes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOperacoes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvOperacoes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOperacoes.RowTemplate.DividerHeight = 1;
            this.dgvOperacoes.RowTemplate.Height = 25;
            this.dgvOperacoes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperacoes.Size = new System.Drawing.Size(626, 277);
            this.dgvOperacoes.TabIndex = 1;
            // 
            // RG
            // 
            this.RG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.RG.DefaultCellStyle = dataGridViewCellStyle2;
            this.RG.FillWeight = 96.08122F;
            this.RG.HeaderText = "X";
            this.RG.Name = "RG";
            this.RG.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RG.Width = 40;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 197.9696F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome.FillWeight = 96.08122F;
            this.Nome.HeaderText = "Nome da operação";
            this.Nome.Name = "Nome";
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 185;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.FillWeight = 96.08122F;
            this.Email.HeaderText = "Condição";
            this.Email.Name = "Email";
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 150;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Telefone.FillWeight = 96.08122F;
            this.Telefone.HeaderText = "Valor";
            this.Telefone.Name = "Telefone";
            this.Telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefone.Width = 95;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPF.FillWeight = 96.08122F;
            this.CPF.HeaderText = "";
            this.CPF.Name = "CPF";
            this.CPF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CPF.Width = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 56);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA DE EMISSÃO:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 23);
            this.textBox2.TabIndex = 3;
            // 
            // dgvValor
            // 
            this.dgvValor.AllowUserToResizeColumns = false;
            this.dgvValor.AllowUserToResizeRows = false;
            this.dgvValor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvValor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvValor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvValor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvValor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvValor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvValor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvValor.EnableHeadersVisualStyles = false;
            this.dgvValor.Location = new System.Drawing.Point(713, 102);
            this.dgvValor.Name = "dgvValor";
            this.dgvValor.RowHeadersVisible = false;
            this.dgvValor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvValor.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvValor.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvValor.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvValor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvValor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvValor.RowTemplate.DividerHeight = 1;
            this.dgvValor.RowTemplate.Height = 25;
            this.dgvValor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvValor.Size = new System.Drawing.Size(452, 446);
            this.dgvValor.TabIndex = 4;
            this.dgvValor.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvValor_CellValidating);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.FillWeight = 96.08122F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Descontos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 235;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.FillWeight = 96.08122F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Acréscimos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 215;
            // 
            // dgvsalario
            // 
            this.dgvsalario.AllowUserToAddRows = false;
            this.dgvsalario.AllowUserToDeleteRows = false;
            this.dgvsalario.AllowUserToResizeColumns = false;
            this.dgvsalario.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvsalario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvsalario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvsalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvsalario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvsalario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsalario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvsalario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvsalario.ColumnHeadersVisible = false;
            this.dgvsalario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsalario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvsalario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvsalario.Location = new System.Drawing.Point(713, 546);
            this.dgvsalario.Name = "dgvsalario";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsalario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvsalario.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvsalario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvsalario.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvsalario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvsalario.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvsalario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvsalario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvsalario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvsalario.RowTemplate.DividerHeight = 1;
            this.dgvsalario.RowTemplate.Height = 25;
            this.dgvsalario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsalario.Size = new System.Drawing.Size(452, 52);
            this.dgvsalario.TabIndex = 5;
            // 
            // column1
            // 
            this.column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.column1.FillWeight = 96.08122F;
            this.column1.HeaderText = "Salário Bruto:";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column1.Width = 225;
            // 
            // column2
            // 
            this.column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.column2.HeaderText = "aaaaa";
            this.column2.Name = "column2";
            this.column2.ReadOnly = true;
            this.column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column2.Width = 225;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(1052, 604);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerar.Location = new System.Drawing.Point(913, 604);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(100, 39);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dgvBancodehoras
            // 
            this.dgvBancodehoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBancodehoras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBancodehoras.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBancodehoras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBancodehoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBancodehoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBancodehoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cargo,
            this.Cargahorarioacumprir,
            this.Totalhorastrabalhadas,
            this.Dias});
            this.dgvBancodehoras.EnableHeadersVisualStyles = false;
            this.dgvBancodehoras.Location = new System.Drawing.Point(3, 414);
            this.dgvBancodehoras.Name = "dgvBancodehoras";
            this.dgvBancodehoras.RowHeadersVisible = false;
            this.dgvBancodehoras.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBancodehoras.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvBancodehoras.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvBancodehoras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBancodehoras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvBancodehoras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBancodehoras.RowTemplate.DividerHeight = 1;
            this.dgvBancodehoras.RowTemplate.Height = 25;
            this.dgvBancodehoras.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBancodehoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBancodehoras.Size = new System.Drawing.Size(626, 194);
            this.dgvBancodehoras.TabIndex = 10;
            // 
            // Cargo
            // 
            this.Cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cargahorarioacumprir
            // 
            this.Cargahorarioacumprir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cargahorarioacumprir.FillWeight = 63.91242F;
            this.Cargahorarioacumprir.HeaderText = "Carga Horaria a Cumprir";
            this.Cargahorarioacumprir.Name = "Cargahorarioacumprir";
            this.Cargahorarioacumprir.ReadOnly = true;
            this.Cargahorarioacumprir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Totalhorastrabalhadas
            // 
            this.Totalhorastrabalhadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Totalhorastrabalhadas.FillWeight = 63.91242F;
            this.Totalhorastrabalhadas.HeaderText = "Total de Horas Trabalhadas";
            this.Totalhorastrabalhadas.Name = "Totalhorastrabalhadas";
            this.Totalhorastrabalhadas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias Trabalhados";
            this.Dias.Name = "Dias";
            this.Dias.Width = 120;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.ValidateNames = false;
            // 
            // FormHoleriteGerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1188, 650);
            this.Controls.Add(this.dgvBancodehoras);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvsalario);
            this.Controls.Add(this.dgvValor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 85);
            this.Name = "FormHoleriteGerar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormHoleriteGerar";
            this.Load += new System.EventHandler(this.FormHoleriteGerar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancodehoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOperacoes;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private DataGridView dgvValor;
        private DataGridView dgvsalario;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn column2;
        private Button btnCancelar;
        private Button btnGerar;
        private DataGridView dgvBancodehoras;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Cargahorarioacumprir;
        private DataGridViewTextBoxColumn Totalhorastrabalhadas;
        private DataGridViewTextBoxColumn Dias;
        private SaveFileDialog saveFileDialog1;
    }
}