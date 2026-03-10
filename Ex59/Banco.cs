using System;
using System.Collections.Generic;
using System.Text;

class Banco
{
    
    public static void MostrarConta(Conta conta)
    {
        Console.WriteLine("Titular: " + conta.Titular);
        conta.MostrarTipo();
        Console.WriteLine("Saldo: " + conta.Saldo);
    }
}