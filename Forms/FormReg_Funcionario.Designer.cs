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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnsalvaralteracoes = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreg)).BeginInit();
            this.panel1.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvreg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvreg.Location = new System.Drawing.Point(42, 60);
            this.dgvreg.Name = "dgvreg";
            this.dgvreg.RowHeadersVisible = false;
            this.dgvreg.RowTemplate.Height = 25;
            this.dgvreg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvreg.Size = new System.Drawing.Size(1200, 518);
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
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE CADASTRO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnsalvaralteracoes);
            this.panel1.Controls.Add(this.btnpesquisar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 106);
            this.panel1.TabIndex = 2;
            // 
            // btnsalvaralteracoes
            // 
            this.btnsalvaralteracoes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsalvaralteracoes.FlatAppearance.BorderSize = 0;
            this.btnsalvaralteracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvaralteracoes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsalvaralteracoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalvaralteracoes.Location = new System.Drawing.Point(1014, 20);
            this.btnsalvaralteracoes.Name = "btnsalvaralteracoes";
            this.btnsalvaralteracoes.Size = new System.Drawing.Size(154, 31);
            this.btnsalvaralteracoes.TabIndex = 2;
            this.btnsalvaralteracoes.Text = "Salvar alterações";
            this.btnsalvaralteracoes.UseVisualStyleBackColor = false;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnpesquisar.FlatAppearance.BorderSize = 0;
            this.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnpesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpesquisar.Location = new System.Drawing.Point(370, 7);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(98, 35);
            this.btnpesquisar.TabIndex = 1;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(64, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 23);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 60);
            this.panel2.TabIndex = 3;
            // 
            // FormReg_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvreg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(189, 100);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "FormReg_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormReg_Funcionario";
            this.Load += new System.EventHandler(this.FormReg_Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvreg;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnsalvaralteracoes;
        private Button btnpesquisar;
        private TextBox textBox1;
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
    }
}