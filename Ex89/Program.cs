using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IPagamento> pagamentos = new List<IPagamento>();

        pagamentos.Add(new PagamentoPix(100, "email@pix.com"));
        pagamentos.Add(new PagamentoCartao(250, "1234-5678-9012-3456"));

        foreach (IPagamento pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
            Console.WriteLine("-----------------");
        }
    }
}