using System;

using System;

public class ContaBancaria
{
    private double saldo;

    public ContaBancaria(double saldoInicial)
    {
        if (saldoInicial < 0)
            throw new ArgumentOutOfRangeException("saldoInicial", "O saldo inicial não pode ser negativo.");

        saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
            throw new ArgumentOutOfRangeException("valor", "O valor do depósito deve ser maior que zero.");

        saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
            throw new ArgumentOutOfRangeException("valor", "O valor do saque deve ser maior que zero.");

        if (valor > saldo)
            throw new InvalidOperationException("Saldo insuficiente.");

        saldo -= valor;
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }
}