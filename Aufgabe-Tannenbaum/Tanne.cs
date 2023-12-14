using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aufgabe_Tannenbaum
{
    internal class Tanne
    {
        public int Stammbreite {  get; set; }
        public int Stammhoehe { get; set; }
        public int Kronenhoehe { get; set; }
        
        public void Zeichnung (TextBox textbox)
        {
            // Den Stamm zeichnen
            for (int i = 0; i < Stammhöhe; i++)
            {
                .Text += "*".Repeat(Stammbreite);
            }

            // Die Krone zeichnen
            for (int i = Kronenhoehe; i > 0; i -= 2)
            {
                var text = "*";
               Ausgabe.Text +=  text.repeat(i);
            }
        }

    }
}
