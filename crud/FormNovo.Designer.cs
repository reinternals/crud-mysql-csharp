namespace crud
{
    partial class FormNovo
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboJob = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textUltimoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrimeiroNome = new System.Windows.Forms.TextBox();
            this.lblPrimeiroNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlFooterNovo = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(314, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo cadastro";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.pnlBody.Controls.Add(this.btnCancelar);
            this.pnlBody.Controls.Add(this.comboDepartamento);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.comboJob);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.textSalario);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.textTelefone);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.textEmail);
            this.pnlBody.Controls.Add(this.lblEmail);
            this.pnlBody.Controls.Add(this.textUltimoNome);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.textPrimeiroNome);
            this.pnlBody.Controls.Add(this.lblPrimeiroNome);
            this.pnlBody.Controls.Add(this.btnSalvar);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 90);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(314, 421);
            this.pnlBody.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btnCancelar.Location = new System.Drawing.Point(75, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Items.AddRange(new object[] {
            "IT Helpdesk",
            "Government Sales",
            "Retail Sales",
            "Recruiting",
            "Payroll"});
            this.comboDepartamento.Location = new System.Drawing.Point(52, 328);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(214, 21);
            this.comboDepartamento.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(49, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Departamento";
            // 
            // comboJob
            // 
            this.comboJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJob.FormattingEnabled = true;
            this.comboJob.Items.AddRange(new object[] {
            "President",
            "Administration Vice President",
            "Administration Assistant",
            "Finance Manager",
            "Accountant",
            "Accounting Manager",
            "Public Accountant",
            "Sales Manager",
            "Sales Representative",
            "Purchasing Clerk"});
            this.comboJob.Location = new System.Drawing.Point(52, 279);
            this.comboJob.Name = "comboJob";
            this.comboJob.Size = new System.Drawing.Size(214, 21);
            this.comboJob.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(49, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cargo";
            // 
            // textSalario
            // 
            this.textSalario.BackColor = System.Drawing.Color.White;
            this.textSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSalario.Location = new System.Drawing.Point(52, 230);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(214, 20);
            this.textSalario.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(49, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Salário";
            // 
            // textTelefone
            // 
            this.textTelefone.BackColor = System.Drawing.Color.White;
            this.textTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefone.Location = new System.Drawing.Point(52, 181);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(214, 20);
            this.textTelefone.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(49, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefone";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.White;
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Location = new System.Drawing.Point(52, 133);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(214, 20);
            this.textEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblEmail.Location = new System.Drawing.Point(49, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // textUltimoNome
            // 
            this.textUltimoNome.BackColor = System.Drawing.Color.White;
            this.textUltimoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUltimoNome.Location = new System.Drawing.Point(52, 84);
            this.textUltimoNome.Name = "textUltimoNome";
            this.textUltimoNome.Size = new System.Drawing.Size(214, 20);
            this.textUltimoNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ultimo nome";
            // 
            // textPrimeiroNome
            // 
            this.textPrimeiroNome.BackColor = System.Drawing.Color.White;
            this.textPrimeiroNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrimeiroNome.Location = new System.Drawing.Point(50, 35);
            this.textPrimeiroNome.Name = "textPrimeiroNome";
            this.textPrimeiroNome.Size = new System.Drawing.Size(214, 20);
            this.textPrimeiroNome.TabIndex = 0;
            // 
            // lblPrimeiroNome
            // 
            this.lblPrimeiroNome.AutoSize = true;
            this.lblPrimeiroNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.lblPrimeiroNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblPrimeiroNome.Location = new System.Drawing.Point(47, 19);
            this.lblPrimeiroNome.Name = "lblPrimeiroNome";
            this.lblPrimeiroNome.Size = new System.Drawing.Size(73, 13);
            this.lblPrimeiroNome.TabIndex = 0;
            this.lblPrimeiroNome.Text = "Primeiro nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.btnSalvar.Location = new System.Drawing.Point(163, 365);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlFooterNovo
            // 
            this.pnlFooterNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.pnlFooterNovo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterNovo.Location = new System.Drawing.Point(0, 491);
            this.pnlFooterNovo.Name = "pnlFooterNovo";
            this.pnlFooterNovo.Size = new System.Drawing.Size(314, 20);
            this.pnlFooterNovo.TabIndex = 0;
            // 
            // FormNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(314, 511);
            this.Controls.Add(this.pnlFooterNovo);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlFooterNovo;
        private System.Windows.Forms.TextBox textPrimeiroNome;
        private System.Windows.Forms.Label lblPrimeiroNome;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textUltimoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
    }
}