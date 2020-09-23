using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeLP2
{
    public partial class Form1 : Form
    {        

        private char ops;
        private double valorOp;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bnt0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void btb6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != string.Empty)
            {
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("O campo já está limpo!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOp.Text = string.Empty;
            txtValOp.Text = string.Empty;
            txtVisor.Text = string.Empty;
            this.valorOp = 0;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            guardaValor();
            ops = 'X';
        }

        public void guardaValor ()
        {
            this.valorOp = Double.Parse(txtVisor.Text);
            txtVisor.Text = string.Empty;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
             switch (this.ops)
            {
                case '+':
                    txtVisor.Text = Convert.ToString(Double.Parse(txtVisor.Text) + this.valorOp);
                    break;
                case '-':
                    txtVisor.Text = Convert.ToString(this.valorOp - Double.Parse(txtVisor.Text));
                    break;
                case 'X':
                    txtVisor.Text = Convert.ToString(Double.Parse(txtVisor.Text) * this.valorOp);
                    break;
                case '/':
                    txtVisor.Text = Convert.ToString(Double.Parse(txtVisor.Text) / this.valorOp);
                    break;
            }
            txtOp.Text = string.Empty;
            txtValOp.Text = string.Empty;
            this.valorOp = 0;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            guardaValor();
            ops = '+';
            txtOp.Text = Convert.ToString(ops);
            txtValOp.Text = Convert.ToString(valorOp);

        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            if (txtVisor.Text == null) {
             txtVisor.Text = string.Empty;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == string.Empty)
            {
                txtVisor.Text += "-";
            }
            else if (Convert.ToString(txtVisor.Text)[0].Equals('-')) //&& !Convert.ToString(txtVisor.Text)[1].Equals('-'))
            {
                MessageBox.Show("Operação inválida!");
            }
            else {

                 guardaValor();
                 ops = '-';
            }
        }
    }
}
