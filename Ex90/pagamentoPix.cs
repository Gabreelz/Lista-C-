using System;
using System.Collections.Generic;
using System.Text;

public class PagamentoPix : Pagamento
{
    public string ChavePix { get; set; }

    public PagamentoPix(double valor, string chavePix) : base(valor)
    {
        ChavePix = chavePix;
    }

    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento via PIX");
        Console.WriteLine("Valor: " + Valor);
        Console.WriteLine("Chave: " + ChavePix);
    }
}