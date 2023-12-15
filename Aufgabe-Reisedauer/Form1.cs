using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_Reisedauer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void berechenen_Click(object sender, EventArgs e)
        {
            Mondreise mondreise = new Mondreise();

            mondreise.Geschwindigkeit = Convert.ToDouble(Eingabe.Text);

            if (Hours.Checked)
            {
                Ausgabe.Text = mondreise.GetReisedauerInH().ToString();
            }
            else
            {
                Ausgabe.Text = mondreise.GetReisedauerInD().ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
