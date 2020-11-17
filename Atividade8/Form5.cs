using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_8
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] aluno = { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };
            
            for(var i = 0; i < aluno.Length; i++)
            {
                richTextBox1.Text += aluno[i]+", ";

                if(aluno[i]!= "Otávio")
                {
                    richTextBox2.Text += aluno[i] + ", ";
                }
            }



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
