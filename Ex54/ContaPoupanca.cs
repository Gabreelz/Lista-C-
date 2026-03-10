using System;
using System.Collections.Generic;
using System.Text;

class ContaPoupanca : Conta
{
    public double Juros;

    public void MostrarContaPoupanca()
    {
        Console.WriteLine("Conta Poupança");
        Console.WriteLine("Taxa de juros: " + Juros);
    }
}
