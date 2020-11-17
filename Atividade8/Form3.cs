using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercício_8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string produtos = "";
            string[] Vetor = new string[10];
            string precos = "";
            string[] Vetor2 = new string[10];
            string quantidade = "";
            string[] Vetor3 = new string[10];
            double auxiliar; 

            double f=0,p,q;

            


            for (var i = 0; i < Vetor.Length; i++)
            {
                int x = i + 1;
                produtos = Interaction.InputBox("Insira os produto: "+x, "Produtos");
                Vetor[i] = produtos;
            }
            for (var i = 0; i < Vetor.Length; i++)
            {
                precos = Interaction.InputBox("Insira o preço do "+ Vetor[i].ToString(), "preços");
                
                
                
                if (double.TryParse(precos, out auxiliar)) 
                {
                    Vetor2[i] = precos;
                }
                else
                {
                    MessageBox.Show("Insira um número válido");
                    i--;
                }

            }
            for (var i = 0; i < Vetor.Length; i++)
            {
                quantidade = Interaction.InputBox("Insira a quantidade de: "+ Vetor[i], "quantidade");
                if (double.TryParse(quantidade, out auxiliar))
                {
                    Vetor3[i] = quantidade;
                }
                else
                {
                    MessageBox.Show("Insira um número válido");
                    i--;
                }
            }

            for (var i = 0; i < Vetor.Length; i++)
            {
                p = Convert.ToDouble(Vetor2[i]);
                q= Convert.ToDouble(Vetor3[i]);

                f += p * q;
            }
            MessageBox.Show("Seu faturamento é de: " + f);
        }
    }
}
