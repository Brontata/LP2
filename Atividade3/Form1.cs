using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num;
        double peso;
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rdbtnMasc.Checked) {
                try
                {
                    num = 72.7 * double.Parse(msktxtAlt.Text) - 58;
                    
                }
                catch
                {
                    MessageBox.Show("Insira valores válidos!");
                }
            }
            else if(rdbtnFem.Checked){
                try
                {
                    num = 62.1 * Double.Parse(msktxtAlt.Text) - 44.7;
                }
                catch
                {
                    MessageBox.Show("Insira valores válidos!");
                }
            }
            else
            {
                MessageBox.Show("Selecione o sexo!");
            }

            try
            {
                peso = Double.Parse(txtPeso.Text);
            }
            catch
            {
                MessageBox.Show("Insira um peso válido!");
            }
            try
            {
                if (Math.Round(num, 0) > double.Parse(txtPeso.Text))
                {
                    MessageBox.Show("Coma bastante massas e doces");
                }
                else if (Math.Round(num, 0) < double.Parse(txtPeso.Text))
                {
                    MessageBox.Show("Regime obrigatório já");
                }
                else
                {
                    MessageBox.Show("Você está no peso ideal");
                }
            } catch
            {
                MessageBox.Show("Insira valores válidos!");
            }
        }
    }
}
