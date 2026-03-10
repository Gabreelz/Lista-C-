using System;
using System.Collections.Generic;
using System.Text;

class ContaCorrente : Conta
{
    public override void Sacar(double valor)
    {
        double taxa = 2;
        Saldo -= (valor + taxa);
    }
}
