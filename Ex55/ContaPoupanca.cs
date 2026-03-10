using System;
using System.Collections.Generic;
using System.Text;

class ContaPoupanca : Conta
{
    public double Juros;

    public override void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void MostrarContaPoupanca()
    {
        Console.WriteLine("Conta Poupança");
        Console.WriteLine("Taxa de juros: " + Juros);
    }
}
