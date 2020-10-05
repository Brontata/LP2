namespace Salario
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtnome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mskdtxtboxFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtSalbrut = new System.Windows.Forms.MaskedTextBox();
            this.txtAliqin = new System.Windows.Forms.TextBox();
            this.txtAliqir = new System.Windows.Forms.TextBox();
            this.txtSalf = new System.Windows.Forms.TextBox();
            this.txtSalliq = new System.Windows.Forms.TextBox();
            this.txtDescin = new System.Windows.Forms.TextBox();
            this.txtDescir = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdnF = new System.Windows.Forms.RadioButton();
            this.rbdnM = new System.Windows.Forms.RadioButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de filhos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aliquota INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aliquota IRPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salario familia";
            // 
            // Txtnome
            // 
            this.Txtnome.AutoSize = true;
            this.Txtnome.Location = new System.Drawing.Point(16, 314);
            this.Txtnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txtnome.Name = "Txtnome";
            this.Txtnome.Size = new System.Drawing.Size(100, 18);
            this.Txtnome.TabIndex = 6;
            this.Txtnome.Text = "Salario liquido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Desconto INSS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Desconto IRPF";
            // 
            // mskdtxtboxFilhos
            // 
            this.mskdtxtboxFilhos.Location = new System.Drawing.Point(172, 76);
            this.mskdtxtboxFilhos.Mask = "00";
            this.mskdtxtboxFilhos.Name = "mskdtxtboxFilhos";
            this.mskdtxtboxFilhos.Size = new System.Drawing.Size(100, 24);
            this.mskdtxtboxFilhos.TabIndex = 9;
            // 
            // mskdtxtSalbrut
            // 
            this.mskdtxtSalbrut.Location = new System.Drawing.Point(172, 46);
            this.mskdtxtSalbrut.Mask = "00000000.00";
            this.mskdtxtSalbrut.Name = "mskdtxtSalbrut";
            this.mskdtxtSalbrut.Size = new System.Drawing.Size(100, 24);
            this.mskdtxtSalbrut.TabIndex = 10;
            // 
            // txtAliqin
            // 
            this.txtAliqin.Location = new System.Drawing.Point(123, 173);
            this.txtAliqin.Name = "txtAliqin";
            this.txtAliqin.ReadOnly = true;
            this.txtAliqin.Size = new System.Drawing.Size(100, 24);
            this.txtAliqin.TabIndex = 11;
            // 
            // txtAliqir
            // 
            this.txtAliqir.Location = new System.Drawing.Point(123, 211);
            this.txtAliqir.Name = "txtAliqir";
            this.txtAliqir.ReadOnly = true;
            this.txtAliqir.Size = new System.Drawing.Size(100, 24);
            this.txtAliqir.TabIndex = 12;
            // 
            // txtSalf
            // 
            this.txtSalf.Location = new System.Drawing.Point(123, 244);
            this.txtSalf.Name = "txtSalf";
            this.txtSalf.ReadOnly = true;
            this.txtSalf.Size = new System.Drawing.Size(100, 24);
            this.txtSalf.TabIndex = 13;
            // 
            // txtSalliq
            // 
            this.txtSalliq.Location = new System.Drawing.Point(122, 311);
            this.txtSalliq.Name = "txtSalliq";
            this.txtSalliq.ReadOnly = true;
            this.txtSalliq.Size = new System.Drawing.Size(100, 24);
            this.txtSalliq.TabIndex = 14;
            // 
            // txtDescin
            // 
            this.txtDescin.Location = new System.Drawing.Point(390, 208);
            this.txtDescin.Name = "txtDescin";
            this.txtDescin.ReadOnly = true;
            this.txtDescin.Size = new System.Drawing.Size(100, 24);
            this.txtDescin.TabIndex = 15;
            // 
            // txtDescir
            // 
            this.txtDescir.Location = new System.Drawing.Point(390, 238);
            this.txtDescir.Name = "txtDescir";
            this.txtDescir.ReadOnly = true;
            this.txtDescir.Size = new System.Drawing.Size(100, 24);
            this.txtDescir.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdnF);
            this.groupBox1.Controls.Add(this.rbdnM);
            this.groupBox1.Location = new System.Drawing.Point(377, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbdnF
            // 
            this.rbdnF.AutoSize = true;
            this.rbdnF.Location = new System.Drawing.Point(74, 51);
            this.rbdnF.Name = "rbdnF";
            this.rbdnF.Size = new System.Drawing.Size(35, 22);
            this.rbdnF.TabIndex = 1;
            this.rbdnF.TabStop = true;
            this.rbdnF.Text = "F";
            this.rbdnF.UseVisualStyleBackColor = true;
            // 
            // rbdnM
            // 
            this.rbdnM.AutoSize = true;
            this.rbdnM.Location = new System.Drawing.Point(74, 23);
            this.rbdnM.Name = "rbdnM";
            this.rbdnM.Size = new System.Drawing.Size(39, 22);
            this.rbdnM.TabIndex = 0;
            this.rbdnM.TabStop = true;
            this.rbdnM.Text = "M";
            this.rbdnM.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(172, 9);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 24);
            this.txtname.TabIndex = 19;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(451, 118);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(79, 22);
            this.chkCasado.TabIndex = 20;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(80, 127);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(142, 23);
            this.btnVer.TabIndex = 21;
            this.btnVer.Text = "Verificar dados";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 346);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtDescir);
            this.Controls.Add(this.txtDescin);
            this.Controls.Add(this.txtSalliq);
            this.Controls.Add(this.txtSalf);
            this.Controls.Add(this.txtAliqir);
            this.Controls.Add(this.txtAliqin);
            this.Controls.Add(this.mskdtxtSalbrut);
            this.Controls.Add(this.mskdtxtboxFilhos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txtnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Txtnome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskdtxtboxFilhos;
        private System.Windows.Forms.MaskedTextBox mskdtxtSalbrut;
        private System.Windows.Forms.TextBox txtAliqin;
        private System.Windows.Forms.TextBox txtAliqir;
        private System.Windows.Forms.TextBox txtSalf;
        private System.Windows.Forms.TextBox txtSalliq;
        private System.Windows.Forms.TextBox txtDescin;
        private System.Windows.Forms.TextBox txtDescir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdnF;
        private System.Windows.Forms.RadioButton rbdnM;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.Button btnVer;
    }
}

