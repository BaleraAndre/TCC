namespace Folha_Pagamento.Forms
{
    partial class FormAtualizarFuncionario
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
            this.txtdatanascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtdataadmissao = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtgrauescolaridade = new System.Windows.Forms.ComboBox();
            this.txtestadocivil = new System.Windows.Forms.ComboBox();
            this.txtsexo = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtraca = new System.Windows.Forms.TextBox();
            this.txtpai = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtpis = new System.Windows.Forms.TextBox();
            this.txtmae = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtpaisorigem = new System.Windows.Forms.TextBox();
            this.txtregimetrabalhista = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtorgaoemissor = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdatanascimento
            // 
            this.txtdatanascimento.Location = new System.Drawing.Point(601, 257);
            this.txtdatanascimento.Mask = "00/00/0000";
            this.txtdatanascimento.Name = "txtdatanascimento";
            this.txtdatanascimento.Size = new System.Drawing.Size(214, 23);
            this.txtdatanascimento.TabIndex = 110;
            this.txtdatanascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtdataadmissao
            // 
            this.txtdataadmissao.Location = new System.Drawing.Point(88, 202);
            this.txtdataadmissao.Mask = "00/00/0000";
            this.txtdataadmissao.Name = "txtdataadmissao";
            this.txtdataadmissao.Size = new System.Drawing.Size(203, 23);
            this.txtdataadmissao.TabIndex = 109;
            this.txtdataadmissao.ValidatingType = typeof(System.DateTime);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(871, 94);
            this.txtcpf.Mask = "000000000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(214, 23);
            this.txtcpf.TabIndex = 108;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(88, 144);
            this.txtrg.Mask = "00000000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(203, 23);
            this.txtrg.TabIndex = 107;
            // 
            // txtgrauescolaridade
            // 
            this.txtgrauescolaridade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtgrauescolaridade.FormattingEnabled = true;
            this.txtgrauescolaridade.Items.AddRange(new object[] {
            "Ensino Fundamental incompleto",
            "Ensino Fundamental completo",
            "Ensino Medio incompleto",
            "Ensino Medio completo",
            "Ensino Superior incompleto",
            "Ensino Superior completo",
            ""});
            this.txtgrauescolaridade.Location = new System.Drawing.Point(88, 257);
            this.txtgrauescolaridade.Name = "txtgrauescolaridade";
            this.txtgrauescolaridade.Size = new System.Drawing.Size(203, 23);
            this.txtgrauescolaridade.TabIndex = 106;
            // 
            // txtestadocivil
            // 
            this.txtestadocivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtestadocivil.FormattingEnabled = true;
            this.txtestadocivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Viuvo"});
            this.txtestadocivil.Location = new System.Drawing.Point(871, 200);
            this.txtestadocivil.Name = "txtestadocivil";
            this.txtestadocivil.Size = new System.Drawing.Size(214, 23);
            this.txtestadocivil.TabIndex = 105;
            // 
            // txtsexo
            // 
            this.txtsexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtsexo.FormattingEnabled = true;
            this.txtsexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.txtsexo.Location = new System.Drawing.Point(88, 311);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(203, 23);
            this.txtsexo.TabIndex = 104;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(12, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(136, 32);
            this.label26.TabIndex = 103;
            this.label26.Text = "REGISTRO:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(927, 538);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(141, 61);
            this.btnsalvar.TabIndex = 102;
            this.btnsalvar.Text = "Atualizar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(605, 348);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 15);
            this.label25.TabIndex = 101;
            this.label25.Text = "COMPLEMENTO:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(605, 366);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(210, 23);
            this.txtcomplemento.TabIndex = 100;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(874, 348);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 15);
            this.label24.TabIndex = 99;
            this.label24.Text = "BAIRRO:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(871, 293);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 15);
            this.label23.TabIndex = 98;
            this.label23.Text = "CEP:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(871, 239);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 15);
            this.label22.TabIndex = 97;
            this.label22.Text = "RAÇA/COR:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(871, 184);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 15);
            this.label21.TabIndex = 96;
            this.label21.Text = "ESTADO CIVIL:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(871, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 15);
            this.label20.TabIndex = 95;
            this.label20.Text = "NOME DO PAI:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(871, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 15);
            this.label19.TabIndex = 94;
            this.label19.Text = "CPF:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(609, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 93;
            this.label18.Text = "SENHA:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(605, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 15);
            this.label17.TabIndex = 92;
            this.label17.Text = "DATA DE NASCIMENTO:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(605, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 15);
            this.label16.TabIndex = 91;
            this.label16.Text = "PIS:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(605, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 15);
            this.label15.TabIndex = 90;
            this.label15.Text = "NOME DA MÃE:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(605, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 89;
            this.label14.Text = "TELEFONE:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 348);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 88;
            this.label13.Text = "NUMERO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 87;
            this.label12.Text = "PAIS DE ORIGEM:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 86;
            this.label11.Text = "REGIME TRABALHISTA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 85;
            this.label10.Text = "CARGO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 15);
            this.label9.TabIndex = 84;
            this.label9.Text = "ORGÃO EMISSOR DO RG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 83;
            this.label8.Text = "E-MAIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 82;
            this.label7.Text = "CIDADE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 81;
            this.label6.Text = "ENDEREÇO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 80;
            this.label5.Text = "SEXO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "GRAU DE ESCOLARIDADE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 78;
            this.label3.Text = "DATA DE ADIMISSÃO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "RG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "NOME COMPLETO:";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(874, 366);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(211, 23);
            this.txtbairro.TabIndex = 75;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(871, 311);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(208, 23);
            this.txtcep.TabIndex = 74;
            // 
            // txtraca
            // 
            this.txtraca.Location = new System.Drawing.Point(871, 257);
            this.txtraca.Name = "txtraca";
            this.txtraca.Size = new System.Drawing.Size(211, 23);
            this.txtraca.TabIndex = 73;
            // 
            // txtpai
            // 
            this.txtpai.Location = new System.Drawing.Point(871, 144);
            this.txtpai.Name = "txtpai";
            this.txtpai.Size = new System.Drawing.Size(214, 23);
            this.txtpai.TabIndex = 72;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(605, 311);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(210, 23);
            this.txtsenha.TabIndex = 71;
            // 
            // txtpis
            // 
            this.txtpis.Location = new System.Drawing.Point(601, 200);
            this.txtpis.Name = "txtpis";
            this.txtpis.Size = new System.Drawing.Size(214, 23);
            this.txtpis.TabIndex = 70;
            // 
            // txtmae
            // 
            this.txtmae.Location = new System.Drawing.Point(601, 144);
            this.txtmae.Name = "txtmae";
            this.txtmae.Size = new System.Drawing.Size(214, 23);
            this.txtmae.TabIndex = 69;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(601, 94);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(214, 23);
            this.txttelefone.TabIndex = 68;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(345, 366);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(208, 23);
            this.txtnumero.TabIndex = 67;
            // 
            // txtpaisorigem
            // 
            this.txtpaisorigem.Location = new System.Drawing.Point(345, 311);
            this.txtpaisorigem.Name = "txtpaisorigem";
            this.txtpaisorigem.Size = new System.Drawing.Size(209, 23);
            this.txtpaisorigem.TabIndex = 66;
            // 
            // txtregimetrabalhista
            // 
            this.txtregimetrabalhista.Location = new System.Drawing.Point(344, 257);
            this.txtregimetrabalhista.Name = "txtregimetrabalhista";
            this.txtregimetrabalhista.Size = new System.Drawing.Size(209, 23);
            this.txtregimetrabalhista.TabIndex = 65;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(345, 200);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(209, 23);
            this.txtcargo.TabIndex = 64;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(88, 94);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(203, 23);
            this.txtnome.TabIndex = 63;
            // 
            // txtorgaoemissor
            // 
            this.txtorgaoemissor.Location = new System.Drawing.Point(345, 144);
            this.txtorgaoemissor.Name = "txtorgaoemissor";
            this.txtorgaoemissor.Size = new System.Drawing.Size(209, 23);
            this.txtorgaoemissor.TabIndex = 62;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(345, 94);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(209, 23);
            this.txtemail.TabIndex = 61;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(88, 419);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(203, 23);
            this.txtcidade.TabIndex = 60;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(88, 366);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(203, 23);
            this.txtendereco.TabIndex = 59;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(154, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 32);
            this.lblID.TabIndex = 111;
            this.lblID.Text = "ID";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(761, 538);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(141, 61);
            this.btnRemover.TabIndex = 112;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // FormAtualizarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 690);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtdatanascimento);
            this.Controls.Add(this.txtdataadmissao);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.txtgrauescolaridade);
            this.Controls.Add(this.txtestadocivil);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtraca);
            this.Controls.Add(this.txtpai);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtpis);
            this.Controls.Add(this.txtmae);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtpaisorigem);
            this.Controls.Add(this.txtregimetrabalhista);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtorgaoemissor);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtendereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(189, 70);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "FormAtualizarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informações do funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txtdatanascimento;
        private MaskedTextBox txtdataadmissao;
        private MaskedTextBox txtcpf;
        private MaskedTextBox txtrg;
        private ComboBox txtgrauescolaridade;
        private ComboBox txtestadocivil;
        private ComboBox txtsexo;
        private Label label26;
        private Button btnsalvar;
        private Label label25;
        private TextBox txtcomplemento;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtbairro;
        private TextBox txtcep;
        private TextBox txtraca;
        private TextBox txtpai;
        private TextBox txtsenha;
        private TextBox txtpis;
        private TextBox txtmae;
        private TextBox txttelefone;
        private TextBox txtnumero;
        private TextBox txtpaisorigem;
        private TextBox txtregimetrabalhista;
        private TextBox txtcargo;
        private TextBox txtnome;
        private TextBox txtorgaoemissor;
        private TextBox txtemail;
        private TextBox txtcidade;
        private TextBox txtendereco;
        private Label lblID;
        private Button btnRemover;
    }
}