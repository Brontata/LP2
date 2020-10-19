namespace Metodos
{
    partial class frmEx3
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
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnRem1 = new System.Windows.Forms.Button();
            this.btnRem2 = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(242, 59);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(139, 20);
            this.txtCampo1.TabIndex = 0;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(243, 133);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(138, 20);
            this.txtCampo2.TabIndex = 1;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(113, 62);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(49, 13);
            this.lblPalavra1.TabIndex = 2;
            this.lblPalavra1.Text = "Campo 1";
            this.lblPalavra1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(113, 136);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(49, 13);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Campo 2";
            // 
            // btnRem1
            // 
            this.btnRem1.Location = new System.Drawing.Point(59, 242);
            this.btnRem1.Name = "btnRem1";
            this.btnRem1.Size = new System.Drawing.Size(109, 61);
            this.btnRem1.TabIndex = 4;
            this.btnRem1.Text = "Remover 1 de 2";
            this.btnRem1.UseVisualStyleBackColor = true;
            this.btnRem1.Click += new System.EventHandler(this.btnRemover1_Click);
            // 
            // btnRem2
            // 
            this.btnRem2.Location = new System.Drawing.Point(206, 242);
            this.btnRem2.Name = "btnRem2";
            this.btnRem2.Size = new System.Drawing.Size(109, 61);
            this.btnRem2.TabIndex = 5;
            this.btnRem2.Text = "Remover 2 de 1";
            this.btnRem2.UseVisualStyleBackColor = true;
            this.btnRem2.Click += new System.EventHandler(this.btnRemover2_Click);
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(355, 242);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(109, 61);
            this.btnInv.TabIndex = 6;
            this.btnInv.Text = "Inverter campo";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // frmEx3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 332);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.btnRem2);
            this.Controls.Add(this.btnRem1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.txtCampo1);
            this.Name = "frmEx3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnRem1;
        private System.Windows.Forms.Button btnRem2;
        private System.Windows.Forms.Button btnInv;
    }
}