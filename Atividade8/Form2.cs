using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercício_8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Mirka = "";
            string[] Vetor = new string[20];

            


            for (var i = 0; i < Vetor.Length; i++)
            {
                Mirka = Interaction.InputBox("Mirka", "Chaves");
                Vetor[i] = Mirka;
            }

            Array.Reverse(Vetor);
            for (var j = 0; j < Vetor.Length; j++)
            {
                
                MessageBox.Show(Vetor[j]);

            }
        }
    }
}
