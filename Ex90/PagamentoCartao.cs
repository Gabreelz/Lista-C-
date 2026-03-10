using System;
using System.Collections.Generic;
using System.Text;
public class PagamentoCartao : Pagamento
{
    public string NumeroCartao { get; set; }

    public PagamentoCartao(double valor, string numeroCartao) : base(valor)
    {
        NumeroCartao = numeroCartao;
    }

    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento via Cartão");
        Console.WriteLine("Valor: " + Valor);
        Console.WriteLine("Cartão: " + NumeroCartao);
    }
}