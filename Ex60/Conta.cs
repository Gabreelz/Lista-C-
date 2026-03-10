using System;
using System.Collections.Generic;
using System.Text;

class Conta
{
    public string Titular;
    public double Saldo;

    public virtual void MostrarTipo()
    {
        Console.WriteLine("Conta comum");
    }
}