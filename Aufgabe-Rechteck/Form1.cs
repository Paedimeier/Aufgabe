using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aufgabe_Rechteck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Berechnen_Click(object sender, EventArgs e)
        {
            double wert1 = double.Parse(Breitetxt.Text);
            double wert2 = double.Parse(Höhetxt.Text);
            double ergebnis = wert1 * wert2;
            Ergebnis.Text = ergebnis.ToString();
        }
    }
}