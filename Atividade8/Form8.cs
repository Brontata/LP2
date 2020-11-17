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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Mirka = "";
            string[] Vetor = new string[20];

            


            for (var i = 0; i < Vetor.Length; i++) 
            { Mirka = Interaction.InputBox("Mirka", "Chaves");
                Vetor[i] = Mirka;
            }
            for (var j =Vetor.Length-1 ; j >= 0; j--)
            {
                    MessageBox.Show(Vetor[j]);
                
            }
        }
    }
}
