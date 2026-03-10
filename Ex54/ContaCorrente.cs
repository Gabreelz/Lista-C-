using System;
using System.Collections.Generic;
using System.Text;

class ContaCorrente : Conta
{
    public double Limite;

    public void MostrarContaCorrente()
    {
        Console.WriteLine("Conta Corrente");
        Console.WriteLine("Limite: " + Limite);
    }
}
