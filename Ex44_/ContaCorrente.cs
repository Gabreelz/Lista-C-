using System;
using System.Collections.Generic;
using System.Text;

class ContaCorrente : Conta
{
    public sealed override void MostrarTipo()
    {
        Console.WriteLine("Conta corrente");
    }
}