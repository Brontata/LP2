using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCilindro
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = string.Empty;
            txtVolume.Text = string.Empty;
            txtRaio.Text = string.Empty;
            txtRaio.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out double altura) &&
                   (double.TryParse(txtAltura.Text, out double raio)))
            {
                double volume = Math.PI * Math.Pow(raio, 2) * altura;

                txtVolume.Text = volume.ToString("N2");
            }
            else
                MessageBox.Show("Valores invalidos");
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            txtRaio.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

