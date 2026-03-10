using System;
using System.Collections.Generic;
using System.Text;

    class Consumo
    {
    public double Combustivel { get; set; }
    public virtual double CalcularConsumo()
    {
        return Combustivel / 10;
    }
}

