using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class Form1 : Form
    {
        double salB, salLiq, nFil, salFam, descINSS, descIRPF;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {


            if (double.TryParse(mskdtxtSalbrut.Text, out salB) &&
             double.TryParse(mskdtxtboxFilhos.Text, out nFil) &&
             (rbdnF.Checked || rbdnM.Checked))
            {
                //calculo INSS
                if (salB <= 800.47)
                {
                    descINSS = (7.65 / 100) * salB;
                    txtAliqin.Text = "7,65%";

                }
                else if (salB <= 1050)
                {
                    descINSS = (8.65 / 100) * salB;
                    txtAliqin.Text = "8,65%";

                }
                else if (salB <= 1400.77)
                {
                    descINSS = (9 / 100) * salB;
                    txtAliqin.Text = "9,00%";

                }
                else if (salB <= 2801.56)
                {
                    descINSS = (11 / 100) * salB;
                    txtAliqin.Text = "11,00%";

                }
                else
                {
                    descINSS = 308.17;
                    txtAliqin.Text = "Teto";
                }
                //irpf
                if (salB <= 1257.12)
                {
                    txtAliqir.Text = "isento";
                    txtDescir.Text = "0";
                }
                else if (salB <= 2512.08)
                {
                    txtAliqir.Text = "15,00%";
                    descIRPF = (15 / 100) * salB;
                }
                else
                {
                    txtAliqir.Text = "27,50%";
                    descIRPF = (27.5 / 100) * salB;
                }
                //salario familia
                if (salB < 435.52)
                {
                    salFam = 22.33 * nFil;
                }
                else if (salB <= 654.61)
                {
                    salFam = 15.74 * nFil;
                }
                else
                    salFam = 0;
              
        }
            else
            {
                MessageBox.Show("Preenche tudo ai");
            }




            salLiq = salB + (salFam) - (descIRPF + descINSS);
            
            txtDescir.Text = descIRPF.ToString();
            txtSalf.Text = salFam.ToString();
            txtSalliq.Text = salLiq.ToString();
            txtDescin.Text = descINSS.ToString();
        }
    }
}
