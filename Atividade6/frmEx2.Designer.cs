namespace Metodos
{
    partial class frmEx2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnCampNoOut = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(193, 47);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(193, 91);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Campo 2";
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(31, 194);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(114, 66);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "Verificar se são iguais";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnTestaIguais_Click);
            // 
            // btnCampNoOut
            // 
            this.btnCampNoOut.Location = new System.Drawing.Point(193, 194);
            this.btnCampNoOut.Name = "btnCampNoOut";
            this.btnCampNoOut.Size = new System.Drawing.Size(120, 66);
            this.btnCampNoOut.TabIndex = 5;
            this.btnCampNoOut.Text = "Inserir o primeiro campo no outro";
            this.btnCampNoOut.UseVisualStyleBackColor = true;
            this.btnCampNoOut.Click += new System.EventHandler(this.btnPrimeiroESegundo_Click);
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(359, 194);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(109, 66);
            this.btnIns.TabIndex = 6;
            this.btnIns.Text = "Inserir **";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // frmEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 344);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.btnCampNoOut);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmEx2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnCampNoOut;
        private System.Windows.Forms.Button btnIns;
    }
}