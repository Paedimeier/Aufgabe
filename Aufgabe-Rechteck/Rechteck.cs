using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Rechteck
{
    internal class Rechteck
    {
        double height;
        double width;


        public Rechteck()
        { 
            
        }
  
        public double Height 
        { 
            get { return height; } 
            set {  height = value; }
        }


        public double Width 
        {
            get { return width;  }
            set { width = value; }
        } 

        /// <summary>
        /// Berechnet die Fläche und gibt sie zurück.
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return height * width;
        }

        
    }
}
