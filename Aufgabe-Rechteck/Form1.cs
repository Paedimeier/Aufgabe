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
            Rechteck rechteck = new Rechteck();
            rechteck.Height = Convert.ToDouble(Höhetxt.Text);
            rechteck.Width = Convert.ToDouble(Breitetxt.Text);

            MessageBox.Show(rechteck.Height.ToString());

            Ergebnis.Text = rechteck.GetArea().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}