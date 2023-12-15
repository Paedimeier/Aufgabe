using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_Tannenbaum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(breite.Text);
            int sh = Convert.ToInt32(SHöhe.Text);
            int kh = Convert.ToInt32(KHöhe.Text);
            Tanne t = new Tanne(b, sh, kh);
            t.Zeichne();
            Ausgabe.Text = t.Zeichnung;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
