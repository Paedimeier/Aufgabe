using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_Warenkorb
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        public static bool form2Open = false;

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2Open = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
    }
}
