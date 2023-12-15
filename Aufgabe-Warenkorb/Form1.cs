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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool form2Open = false;
        private Form2 warenkorb;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!form2Open)
            {
                warenkorb = new Form2();
                form2Open = true;
                warenkorb.FormClosed += Warenkorb_FormClosed;
                warenkorb.Show();
            }
            else
            {
                MessageBox.Show("Der Warenkorb ist bereits geöffnet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Warenkorb_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2Open = false;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void count_Click(object sender, EventArgs e)
        {

        }
    }
}
