using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gestionDeSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NP np = new NP();
            np.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas();
            citas.Show();
        }

        private void gestiónDeSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GS gs = new GS();
            gs.Show();
        }

        private void sistemaContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SC sc = new SC();
            sc.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RA ra = new RA();
            ra.Show();
        }
    }
}
