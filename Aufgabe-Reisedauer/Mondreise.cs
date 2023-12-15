using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mondreise
{
    double geschwindigkeit;
    double entfernung;
    double reisedauer;

    public double Geschwindigkeit
    {
        get { return geschwindigkeit; }
        set { geschwindigkeit = value; }
    }
    public Mondreise()
    {
        entfernung = 384400;
    }
    public double GetReisedauerInH()
    {
        return entfernung / geschwindigkeit;
    }
    public double GetReisedauerInD()
    {
        return (entfernung / geschwindigkeit) / 24;
    }
}
