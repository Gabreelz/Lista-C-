using System;
using System.Collections.Generic;
using System.Text;
public class Pagamento : IPagamento
{
    public double Valor { get; set; }

    public Pagamento(double valor)
    {
        Valor = valor;
    }

    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico: " + Valor);
    }
}