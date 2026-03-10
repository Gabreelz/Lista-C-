using System;
using System.Collections.Generic;
using System.Text;

class ContaEspecial : ContaCorrente
{
    public double Limite;

    public override void Sacar(double valor)
    {
        if (Saldo + Limite >= valor)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Limite insuficiente.");
        }
    }
}