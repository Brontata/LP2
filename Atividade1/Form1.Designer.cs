namespace WindowsFormsApp1
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
            this.Raio = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Raio
            // 
            this.Raio.AutoSize = true;
            this.Raio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raio.Location = new System.Drawing.Point(117, 51);
            this.Raio.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Raio.MaximumSize = new System.Drawing.Size(333, 300);
            this.Raio.Name = "Raio";
            this.Raio.Size = new System.Drawing.Size(38, 19);
            this.Raio.TabIndex = 0;
            this.Raio.Text = "Raio";
            this.Raio.Click += new System.EventHandler(this.label1_Click);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.Location = new System.Drawing.Point(98, 132);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(57, 19);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "Volume";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(107, 85);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(48, 19);
            this.altura.TabIndex = 4;
            this.altura.Text = "Altura";
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(176, 201);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(97, 31);
            this.Calcular.TabIndex = 5;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR.Location = new System.Drawing.Point(161, 48);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(132, 27);
            this.textBoxR.TabIndex = 7;
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA.Location = new System.Drawing.Point(161, 85);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(132, 27);
            this.textBoxA.TabIndex = 8;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxV
            // 
            this.textBoxV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxV.Location = new System.Drawing.Point(161, 129);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.ReadOnly = true;
            this.textBoxV.Size = new System.Drawing.Size(132, 27);
            this.textBoxV.TabIndex = 9;
            this.textBoxV.TextChanged += new System.EventHandler(this.textBoxV_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(454, 285);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.Raio);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.Calcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Raio;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxV;
    }
}

