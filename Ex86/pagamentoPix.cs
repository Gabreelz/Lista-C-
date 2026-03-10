using System;
using System.Collections.Generic;
using System.Text;

public class PagamentoPix : Pagamento
{
    public string ChavePix { get; set; }

    public PagamentoPix(int id, double valor, string chavePix)
        : base(id, valor)
    {
        ChavePix = chavePix;
    }

    public override void ExibirPagamento()
    {
        base.ExibirPagamento();
        Console.WriteLine("Chave PIX: " + ChavePix);
    }
}
