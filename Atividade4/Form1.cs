using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (a != 0 && b != 0 && c != 0)
            {
                try
            {
                a = Math.Abs(Double.Parse(txtA.Text));
                b = Math.Abs(Double.Parse(txtB.Text));
                c = Math.Abs(Double.Parse(txtC.Text));
            }
            catch 
            {
                MessageBox.Show("Insira valores válidos");
            }
            
                if (a == b && b == c)
                {
                    MessageBox.Show("O triângulo é equilátero");
                }
                else if (a != b && b != c && c != a)
                {
                    MessageBox.Show("O triângulo é escaleno");
                }
                else
                {
                    MessageBox.Show("O triângulo é isósceles");
                }
            }
            else
            {
                MessageBox.Show("Insira valores válidos");
            }
        }
    }
}
