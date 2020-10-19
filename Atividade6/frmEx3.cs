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
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover1_Click(object sender, EventArgs e)
        {
            int posicao = txtCampo2.Text.IndexOf(txtCampo1.Text);

            while (posicao >= 0)
            {

                txtCampo2.Text = txtCampo2.Text.Substring(0, posicao) +
                    txtCampo2.Text.Substring(posicao + txtCampo1.Text.Length,
                    txtCampo2.Text.Length - txtCampo1.Text.Length - posicao);

                posicao = txtCampo2.Text.IndexOf(txtCampo1.Text);
            }
        }

        private void btnRemover2_Click(object sender, EventArgs e)
        {
            txtCampo2.Text = txtCampo2.Text.Replace(txtCampo1.Text, "");
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            char[] auxiliar = txtCampo1.Text.ToCharArray();
            Array.Reverse(auxiliar);

            foreach (char c in auxiliar)
                txtCampo2.Text += c;
        }
    }
}
