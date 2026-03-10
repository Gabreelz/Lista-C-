using System;
using System.Collections.Generic;
using System.Text;

class ContaPoupanca : Conta
{
    public override void MostrarTipo()
    {
        Console.WriteLine("Conta Poupança");
    }
}