using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
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

        private void btn0_Click(object sender, EventArgs e)
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

        private void btn6_Click(object sender, EventArgs e)
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
                MessageBox.Show("Os campos já estão limpos!");
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
            txtOp.Text = Convert.ToString(ops);
            txtValOp.Text = Convert.ToString(valorOp);
        }

        public void guardaValor ()
        {
            if (txtVisor.Text == string.Empty)
            {
                MessageBox.Show("Operação inválida");
            }
            else
            {
                try{
                    this.valorOp = Double.Parse(txtVisor.Text);
                    txtVisor.Text = string.Empty;
                }
                catch {
                    MessageBox.Show("Operação inválida");
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {           
                switch (this.ops)
                {
                    case '+':
                        try
                        {
                            txtVisor.Text = Convert.ToString(Double.Parse(txtVisor.Text) + this.valorOp);
                        }
                        catch
                        {
                            MessageBox.Show("Operação inválida");
                        }
                        break;
                    case '-':
                        txtVisor.Text = Convert.ToString(this.valorOp - Double.Parse(txtVisor.Text));
                        break;
                    case 'X':
                    try
                    {
                        txtVisor.Text = Convert.ToString(Double.Parse(txtVisor.Text) * this.valorOp);
                    }
                    catch
                    {
                        MessageBox.Show("Operação inválida");
                    }
                        break;
                    case '/':
                    if (Double.Parse(txtVisor.Text) == 0 || this.valorOp == 0 && this.ops.Equals('/'))
                    {
                        MessageBox.Show("Operação inválida");
                    }
                    else
                    {
                        txtVisor.Text = Convert.ToString(this.valorOp /Double.Parse(txtVisor.Text));
                    }
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
            else { 
                 guardaValor();
                 ops = '-';
                txtOp.Text = Convert.ToString(ops);
                txtValOp.Text = Convert.ToString(valorOp);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            guardaValor();
            ops = '/';
            txtOp.Text = Convert.ToString(ops);
            txtValOp.Text = Convert.ToString(valorOp);
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            txtVisor.Text += ",";
        }

        private void imgBonk_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\source\sound\bonk.wav");
            simpleSound.Play();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;
                case Keys.Back:
                    btnDel.PerformClick();
                    break;
                case Keys.Subtract:
                    btnSub.PerformClick();
                    break;
                case Keys.Add:
                    btnSoma.PerformClick();
                    break;
                case Keys.Divide:
                    btnDiv.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMult.PerformClick();
                    break;
                case Keys.Decimal:
                    btnVirg.PerformClick();
                    break;
                case Keys.Enter:
                    btnIgual.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
