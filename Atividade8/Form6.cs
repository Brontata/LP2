using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercício_8
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nomes = "";
            string Notas = "";
            string[,] Media = new string[20, 4];

            double aux, MediaCalc, Nota1, Nota2, Nota3;

            for (int i = 0; i < 20; i++)
            {
                Nomes = Interaction.InputBox("Nomes", "pudim");
                Media[i, 0] = Nomes;


                for (int j = 1; j < 4; j++)
                {

                    Notas = Interaction.InputBox("Notas", "pudim");
                    if (double.TryParse(Notas, out aux))
                    {
                        Media[i, j] = Notas;
                    }
                    else
                    {
                        MessageBox.Show("Digite uma nota válida");
                    }

                }
                Nota1 = Convert.ToDouble(Media[i, 1]);
                Nota2 = Convert.ToDouble(Media[i, 2]);
                Nota3 = Convert.ToDouble(Media[i, 3]);

                MediaCalc = (Nota1 + Nota2 + Nota3) / 3;

                richTextBox1.Text += (Media[i, 0] + ": " + "Nota 1: " + " " + Media[i, 1]+ "Nota 2: " + " " + Media[i, 2] + " "+ "Nota 3:  " + Media[i, 3] + " " + "e sua média é: " + MediaCalc+"\n");




            }

        }




    
                    
              
             

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

