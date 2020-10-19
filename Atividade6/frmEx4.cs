using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos
{
    public partial class frmEx4 : Form
    {
        public frmEx4()
        {
            InitializeComponent();
        }

        private void btnContaNumero_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i < rchtxtTexto.Text.Length; i++)
            {

                if (char.IsNumber(rchtxtTexto.Text[i]))
                    contador += 1;
            }
            MessageBox.Show("Quantidade de números: " + contador);
        }

        private void btnContaLetra_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i < rchtxtTexto.Text.Length; i++)
            {

                if (char.IsLetter(rchtxtTexto.Text[i]))
                    contador += 1;
            }
            MessageBox.Show("Quantidade de letras: " + contador);
        }

        private void btnPosição_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i < rchtxtTexto.Text.Length; i++)
            {


                if (char.IsWhiteSpace(rchtxtTexto.Text[i]))
                    { contador = i + 1;
                    break;
                    }
                   
                
                
            }
            MessageBox.Show("O primeiro espaço vazio é na posição: " + contador);
        }

        
    }
}

