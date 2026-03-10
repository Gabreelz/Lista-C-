using System;
using System.Collections.Generic;
using System.Text;

using System;

abstract class Forma
{
    public string Cor;

    public abstract double CalcularArea();

    public void MostrarCor()
    {
        Console.WriteLine("Cor da forma: " + Cor);
    }
}