using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mondreise
{
    private double _geschwindigkeit;
    private double _entfernung;
    private double _reisedauer;
    private string _einheit;

    public Mondreise(double geschwindigkeit)
    {
        _geschwindigkeit = geschwindigkeit;
        _entfernung = 384400;
        _reisedauer = _entfernung / _geschwindigkeit;
        _einheit = "Stunden";
    }

    public double GetReisedauer()
    {
        return _reisedauer;
    }

    public string GetEinheit()
    {
        return _einheit;
    }

    public void SetEinheit(string einheit)
    {

    }
}
