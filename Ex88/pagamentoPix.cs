using System;
using System.Collections.Generic;
using System.Text;

public class PagamentoPix : IPagamento
{
    public double Valor { get; set; }
    public string ChavePix { get; set; }

    public PagamentoPix(double valor, string chavePix)
    {
        Valor = valor;
        ChavePix = chavePix;
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento via PIX");
        Console.WriteLine("Valor: " + Valor);
        Console.WriteLine("Chave: " + ChavePix);
    }
}
