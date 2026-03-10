using System;
using System.Collections.Generic;
using System.Text;
public class PagamentoCartao : Pagamento
{
    public string NumeroCartao { get; set; }

    public PagamentoCartao(int id, double valor, string numeroCartao)
        : base(id, valor)
    {
        NumeroCartao = numeroCartao;
    }

    public override void ExibirPagamento()
    {
        base.ExibirPagamento();
        Console.WriteLine("Número do Cartão: " + NumeroCartao);
    }
}