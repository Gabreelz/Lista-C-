class Program
{
    static void Main()
    {
        ContaCorrente contaCorrente = new ContaCorrente();
        cc.Titular = "Tony";
        cc.Saldo = 1500;

        ContaPremium contaPremium = new ContaPremium();
        cp.Titular = "Peter";
        cp.Saldo = 3000;

        Banco.MostrarConta(contaCorrente);
        Banco.MostrarConta(contaPremium);
    }
}