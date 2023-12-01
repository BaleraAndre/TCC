namespace Folha_Pagamento.Forms
{
    partial class FormReg_Funcionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg_Funcionario));
            this.dgvreg = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orgao_Emissor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Mae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Pai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_admissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grau_Escolaridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regime_Trabalhista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnfiltrarregistros = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnbuscarcolaborador = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbuscartodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvreg
            // 
            this.dgvreg.AllowUserToAddRows = false;
            this.dgvreg.AllowUserToDeleteRows = false;
            this.dgvreg.AllowUserToResizeColumns = false;
            this.dgvreg.AllowUserToResizeRows = false;
            this.dgvreg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvreg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvreg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvreg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvreg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Email,
            this.Telefone,
            this.CPF,
            this.RG,
            this.Orgao_Emissor,
            this.Nome_Mae,
            this.Nome_Pai,
            this.Data_admissao,
            this.Cargo,
            this.PIS,
            this.Estado_Civil,
            this.Grau_Escolaridade,
            this.Regime_Trabalhista,
            this.Data_Nascimento,
            this.Raca,
            this.Sexo,
            this.Pais_Origem,
            this.CEP,
            this.Endereco,
            this.Numero,
            this.Complemento,
            this.Bairro,
            this.Cidade});
            this.dgvreg.EnableHeadersVisualStyles = false;
            this.dgvreg.Location = new System.Drawing.Point(17, 60);
            this.dgvreg.Name = "dgvreg";
            this.dgvreg.RowHeadersVisible = false;
            this.dgvreg.RowTemplate.Height = 25;
            this.dgvreg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvreg.Size = new System.Drawing.Size(1239, 373);
            this.dgvreg.TabIndex = 0;
            this.dgvreg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvreg_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 197.9696F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome.FillWeight = 96.08122F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 200;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.FillWeight = 96.08122F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 185;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Telefone.FillWeight = 96.08122F;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefone.Width = 120;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPF.FillWeight = 96.08122F;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CPF.Width = 120;
            // 
            // RG
            // 
            this.RG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RG.FillWeight = 96.08122F;
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RG.Width = 120;
            // 
            // Orgao_Emissor
            // 
            this.Orgao_Emissor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Orgao_Emissor.FillWeight = 96.08122F;
            this.Orgao_Emissor.HeaderText = "Orgao Emissor";
            this.Orgao_Emissor.Name = "Orgao_Emissor";
            this.Orgao_Emissor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Orgao_Emissor.Width = 50;
            // 
            // Nome_Mae
            // 
            this.Nome_Mae.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome_Mae.FillWeight = 96.08122F;
            this.Nome_Mae.HeaderText = "Nome da Mãe";
            this.Nome_Mae.Name = "Nome_Mae";
            this.Nome_Mae.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome_Mae.Width = 200;
            // 
            // Nome_Pai
            // 
            this.Nome_Pai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome_Pai.FillWeight = 96.08122F;
            this.Nome_Pai.HeaderText = "Nome do Pai";
            this.Nome_Pai.Name = "Nome_Pai";
            this.Nome_Pai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome_Pai.Width = 200;
            // 
            // Data_admissao
            // 
            this.Data_admissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Data_admissao.FillWeight = 96.08122F;
            this.Data_admissao.HeaderText = "Data de Admissão";
            this.Data_admissao.Name = "Data_admissao";
            this.Data_admissao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cargo
            // 
            this.Cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cargo.FillWeight = 96.08122F;
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cargo.Width = 150;
            // 
            // PIS
            // 
            this.PIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PIS.FillWeight = 96.08122F;
            this.PIS.HeaderText = "PIS";
            this.PIS.Name = "PIS";
            this.PIS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PIS.Width = 150;
            // 
            // Estado_Civil
            // 
            this.Estado_Civil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado_Civil.FillWeight = 96.08122F;
            this.Estado_Civil.HeaderText = "Estado Civil";
            this.Estado_Civil.Name = "Estado_Civil";
            this.Estado_Civil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado_Civil.Width = 150;
            // 
            // Grau_Escolaridade
            // 
            this.Grau_Escolaridade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Grau_Escolaridade.FillWeight = 96.08122F;
            this.Grau_Escolaridade.HeaderText = "Grau de Escolaridade";
            this.Grau_Escolaridade.Name = "Grau_Escolaridade";
            this.Grau_Escolaridade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Grau_Escolaridade.Width = 200;
            // 
            // Regime_Trabalhista
            // 
            this.Regime_Trabalhista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Regime_Trabalhista.FillWeight = 96.08122F;
            this.Regime_Trabalhista.HeaderText = "Regime Trabalhista";
            this.Regime_Trabalhista.Name = "Regime_Trabalhista";
            this.Regime_Trabalhista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Regime_Trabalhista.Width = 200;
            // 
            // Data_Nascimento
            // 
            this.Data_Nascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Data_Nascimento.FillWeight = 96.08122F;
            this.Data_Nascimento.HeaderText = "Data de nascimento";
            this.Data_Nascimento.Name = "Data_Nascimento";
            this.Data_Nascimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Nascimento.Width = 150;
            // 
            // Raca
            // 
            this.Raca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Raca.FillWeight = 96.08122F;
            this.Raca.HeaderText = "Raça/Cor";
            this.Raca.Name = "Raca";
            this.Raca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sexo.FillWeight = 96.08122F;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Pais_Origem
            // 
            this.Pais_Origem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pais_Origem.FillWeight = 96.08122F;
            this.Pais_Origem.HeaderText = "Pais de Origem";
            this.Pais_Origem.Name = "Pais_Origem";
            this.Pais_Origem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Pais_Origem.Width = 112;
            // 
            // CEP
            // 
            this.CEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CEP.FillWeight = 96.08122F;
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CEP.Width = 120;
            // 
            // Endereco
            // 
            this.Endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Endereco.FillWeight = 96.08122F;
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Endereco.Width = 150;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Numero.FillWeight = 96.08122F;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Complemento
            // 
            this.Complemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Complemento.FillWeight = 96.08122F;
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            this.Complemento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Complemento.Width = 150;
            // 
            // Bairro
            // 
            this.Bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Bairro.FillWeight = 96.08122F;
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cidade
            // 
            this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cidade.FillWeight = 96.08122F;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cidade.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE FUNCIONARIOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 205);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnfiltrarregistros);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtcidade);
            this.panel4.Controls.Add(this.txtcargo);
            this.panel4.Controls.Add(this.txtbairro);
            this.panel4.Location = new System.Drawing.Point(595, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 154);
            this.panel4.TabIndex = 10;
            // 
            // btnfiltrarregistros
            // 
            this.btnfiltrarregistros.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnfiltrarregistros.Image = ((System.Drawing.Image)(resources.GetObject("btnfiltrarregistros.Image")));
            this.btnfiltrarregistros.Location = new System.Drawing.Point(480, 60);
            this.btnfiltrarregistros.Name = "btnfiltrarregistros";
            this.btnfiltrarregistros.Size = new System.Drawing.Size(75, 63);
            this.btnfiltrarregistros.TabIndex = 15;
            this.btnfiltrarregistros.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(-1, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filtrar por cargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(-1, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Filtrar por bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(-1, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Filtrar por cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(138, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Filtrar todos registros";
            // 
            // txtcidade
            // 
            this.txtcidade.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtcidade.Location = new System.Drawing.Point(162, 46);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(304, 23);
            this.txtcidade.TabIndex = 6;
            // 
            // txtcargo
            // 
            this.txtcargo.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtcargo.Location = new System.Drawing.Point(162, 117);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(304, 23);
            this.txtcargo.TabIndex = 8;
            // 
            // txtbairro
            // 
            this.txtbairro.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbairro.Location = new System.Drawing.Point(162, 83);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(304, 23);
            this.txtbairro.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnbuscarcolaborador);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtcpf);
            this.panel3.Controls.Add(this.txtnome);
            this.panel3.Controls.Add(this.txtemail);
            this.panel3.Location = new System.Drawing.Point(12, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 155);
            this.panel3.TabIndex = 9;
            // 
            // btnbuscarcolaborador
            // 
            this.btnbuscarcolaborador.BackColor = System.Drawing.Color.White;
            this.btnbuscarcolaborador.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarcolaborador.Image")));
            this.btnbuscarcolaborador.Location = new System.Drawing.Point(483, 60);
            this.btnbuscarcolaborador.Name = "btnbuscarcolaborador";
            this.btnbuscarcolaborador.Size = new System.Drawing.Size(75, 63);
            this.btnbuscarcolaborador.TabIndex = 14;
            this.btnbuscarcolaborador.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(-2, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buscar por CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-2, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Buscar por email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-2, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Buscar por nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar colaborador";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(162, 117);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(304, 23);
            this.txtcpf.TabIndex = 10;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(162, 46);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(304, 23);
            this.txtnome.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(162, 83);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(304, 23);
            this.txtemail.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnbuscartodos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 60);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(909, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mostrar todos ";
            // 
            // btnbuscartodos
            // 
            this.btnbuscartodos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscartodos.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscartodos.Image")));
            this.btnbuscartodos.Location = new System.Drawing.Point(1052, 8);
            this.btnbuscartodos.Name = "btnbuscartodos";
            this.btnbuscartodos.Size = new System.Drawing.Size(56, 42);
            this.btnbuscartodos.TabIndex = 18;
            this.btnbuscartodos.UseVisualStyleBackColor = false;
            this.btnbuscartodos.Click += new System.EventHandler(this.btnbuscartodos_Click);
            // 
            // FormReg_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvreg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(185, 1);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "FormReg_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormReg_Funcionario";
            this.Load += new System.EventHandler(this.FormReg_Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvreg;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn Orgao_Emissor;
        private DataGridViewTextBoxColumn Nome_Mae;
        private DataGridViewTextBoxColumn Nome_Pai;
        private DataGridViewTextBoxColumn Data_admissao;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn PIS;
        private DataGridViewTextBoxColumn Estado_Civil;
        private DataGridViewTextBoxColumn Grau_Escolaridade;
        private DataGridViewTextBoxColumn Regime_Trabalhista;
        private DataGridViewTextBoxColumn Data_Nascimento;
        private DataGridViewTextBoxColumn Raca;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Pais_Origem;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Cidade;
        private TextBox txtnome;
        private Panel panel3;
        private MaskedTextBox txtcpf;
        private TextBox txtemail;
        private TextBox txtcargo;
        private TextBox txtbairro;
        private TextBox txtcidade;
        private Panel panel4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnfiltrarregistros;
        private Button btnbuscarcolaborador;
        private Button btnbuscartodos;
        private Label label10;
    }
}