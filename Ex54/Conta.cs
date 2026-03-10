using System;
using System.Collections.Generic;
using System.Text;

class Conta
{
    public string Titular;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void MostrarSaldo()
    {
        Console.WriteLine("Titular: " + Titular);
        Console.WriteLine("Saldo: " + Saldo);
    }
}
