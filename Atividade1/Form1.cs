using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            {
                double altura, raio;

                if (double.TryParse(textBoxA.Text, out altura) &&
                   (double.TryParse(textBoxR.Text, out raio)))
                {
                    double volume;
                    volume = Math.PI * Math.Pow(raio, 2) * altura;

                    textBoxV.Text = volume.ToString("N2");
                }
                else
                    MessageBox.Show("Valores invalidos");
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxV_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
