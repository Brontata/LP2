namespace Metodos
{
    partial class frmEx4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnContNum = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnContCarac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(103, 67);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(276, 131);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnContNum
            // 
            this.btnContNum.Location = new System.Drawing.Point(29, 266);
            this.btnContNum.Name = "btnContNum";
            this.btnContNum.Size = new System.Drawing.Size(115, 64);
            this.btnContNum.TabIndex = 1;
            this.btnContNum.Text = "Contar números";
            this.btnContNum.UseVisualStyleBackColor = true;
            this.btnContNum.Click += new System.EventHandler(this.btnContaNumero_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(186, 266);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(115, 64);
            this.btnPos.TabIndex = 2;
            this.btnPos.Text = "Posição vazia";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPosição_Click);
            // 
            // btnContCarac
            // 
            this.btnContCarac.Location = new System.Drawing.Point(350, 266);
            this.btnContCarac.Name = "btnContCarac";
            this.btnContCarac.Size = new System.Drawing.Size(115, 64);
            this.btnContCarac.TabIndex = 3;
            this.btnContCarac.Text = "Contar letras";
            this.btnContCarac.UseVisualStyleBackColor = true;
            this.btnContCarac.Click += new System.EventHandler(this.btnContaLetra_Click);
            // 
            // frmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 427);
            this.Controls.Add(this.btnContCarac);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnContNum);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmEx4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnContNum;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnContCarac;
    }
}