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
        private Mondreise _mondreise;
        private RadioButton radioButtonStunden;
        private Label labelReisedauer;

        public Form1()
        {
            InitializeComponent();
            _mondreise = new Mondreise(1500);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void berechenen_Click(object sender, EventArgs e)
        {
            const double distanz = 384400;
            double geschwindigkeit = double.Parse(Eingabe.Text);
            double reisedauerInStunden = distanz / geschwindigkeit;
            double reisedauerInTagen = reisedauerInStunden / 24;

            if (Hours.Checked)
            {
                Ausgabe.Text = reisedauerInStunden.ToString("0.00");
            }
            else
            {
                Ausgabe.Text = reisedauerInTagen.ToString("0.00");
            }
        }

    }
}
