class Program
{
    static void Main()
    {
        Pagamento p = new Pagamento(1, 150.50);

        p.ExibirPagamento();

        PagamentoPix pix = new PagamentoPix(1, 200.00, "email@pix.com");

        pix.ExibirPagamento();

        PagamentoCartao cartao = new PagamentoCartao(2, 350.00, "1234-5678-9012-3456");

        cartao.ExibirPagamento();
    }
}