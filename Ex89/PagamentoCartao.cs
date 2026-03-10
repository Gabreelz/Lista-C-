using System;
using System.Collections.Generic;
using System.Text;
public class PagamentoCartao : IPagamento
{
    public double Valor { get; set; }
    public string NumeroCartao { get; set; }

    public PagamentoCartao(double valor, string numeroCartao)
    {
        Valor = valor;
        NumeroCartao = numeroCartao;
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento via Cartão");
        Console.WriteLine("Valor: " + Valor);
        Console.WriteLine("Cartão: " + NumeroCartao);
    }
}