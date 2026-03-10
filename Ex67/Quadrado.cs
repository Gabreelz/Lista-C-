using System;
using System.Collections.Generic;
using System.Text;

class Quadrado : Forma
{
    public double Lado { get; set; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double Area
    {
        get { return Lado * Lado; }
    }
}