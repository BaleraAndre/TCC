namespace Folha_Pagamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnacessar = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEsqueceuSenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnacessar);
            this.panel1.Controls.Add(this.txtsenha);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 353);
            this.panel1.TabIndex = 1;
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(25, 223);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(105, 15);
            this.lblEsqueceuSenha.TabIndex = 4;
            this.lblEsqueceuSenha.TabStop = true;
            this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // btnacessar
            // 
            this.btnacessar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnacessar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnacessar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnacessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnacessar.ForeColor = System.Drawing.Color.White;
            this.btnacessar.Location = new System.Drawing.Point(125, 274);
            this.btnacessar.Name = "btnacessar";
            this.btnacessar.Size = new System.Drawing.Size(104, 43);
            this.btnacessar.TabIndex = 2;
            this.btnacessar.Text = "Acessar";
            this.btnacessar.UseVisualStyleBackColor = false;
            this.btnacessar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.Silver;
            this.txtsenha.Location = new System.Drawing.Point(25, 197);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PlaceholderText = "Senha";
            this.txtsenha.Size = new System.Drawing.Size(305, 23);
            this.txtsenha.TabIndex = 1;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Silver;
            this.txtemail.Location = new System.Drawing.Point(25, 131);
            this.txtemail.Name = "txtemail";
            this.txtemail.PlaceholderText = "E-mail";
            this.txtemail.Size = new System.Drawing.Size(305, 23);
            this.txtemail.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 332);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnacessar;
        private TextBox txtsenha;
        private TextBox txtemail;
        private Label label1;
        private LinkLabel lblEsqueceuSenha;
    }
}