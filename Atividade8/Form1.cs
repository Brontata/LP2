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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio2"];
            if (fc != null)
                fc.Close();
            Form8 exerc2 = new Form8();
            exerc2.MdiParent = this;
            exerc2.WindowState = FormWindowState.Maximized;
            exerc2.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio2"];
            if (fc != null)
                fc.Close();
            Form2 exerc2 = new Form2();
            exerc2.MdiParent = this;
            exerc2.WindowState = FormWindowState.Maximized;
            exerc2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio2"];
            if (fc != null)
                fc.Close();
            Form3 exerc2 = new Form3();
            exerc2.MdiParent = this;
            exerc2.WindowState = FormWindowState.Maximized;
            exerc2.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio2"];
            if (fc != null)
                fc.Close();
            Form4 exerc2 = new Form4();
            exerc2.MdiParent = this;
            exerc2.WindowState = FormWindowState.Maximized;
            exerc2.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio2"];
            if (fc != null)
                fc.Close();
            Form5 exerc2 = new Form5();
            exerc2.MdiParent = this;
            exerc2.WindowState = FormWindowState.Maximized;
            exerc2.Show();
        }

        private void exercício6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio2"];
            if (fc != null)
                fc.Close();
            Form6 exerc2 = new Form6();
            exerc2.MdiParent = this;
            exerc2.WindowState = FormWindowState.Maximized;
            exerc2.Show();
        }

        private void exercício7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio2"];
            if (fc != null)
                fc.Close();
            Form7 exerc2 = new Form7();
            exerc2.MdiParent = this;
            exerc2.WindowState = FormWindowState.Maximized;
            exerc2.Show();
        }
    }
}
