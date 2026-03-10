using System;
using System.Collections.Generic;
using System.Text;

class ContaCorrente : Conta
{
    public double Limite;

    public override void Sacar(double valor)
    {
        double taxa = 2;
        Saldo -= (valor + taxa);

        Console.WriteLine("Saque realizado com taxa de R$2.");
    }


    public void MostrarContaCorrente()
    {
        Console.WriteLine("Conta Corrente");
        Console.WriteLine("Limite: " + Limite);
    }
}

