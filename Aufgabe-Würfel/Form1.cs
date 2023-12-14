using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_Würfel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            Wuerfel wuerfel = new Wuerfel();
        private void Würfel_Click(object sender, EventArgs e)
        {
            int wurf = wuerfel.Werfen();
            int letzerWurf = Convert.ToInt32(wuerfel.LetzterWurf);
            textBox1.Text = wurf.ToString();
            textBox2.Text = letzerWurf.ToString();
        }
    }
}
