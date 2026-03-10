class Program
{
    static void Main()
    {
        ContaCorrente contaCorrente = new ContaCorrente();
        contaCorrente.Titular = "Peter";
        contaCorrente.Saldo = 2000;
        contaCorrente.Limite = 500;

        ContaPoupanca contaPoupanca = new ContaPoupanca();
        contaPoupanca.Titular = "Logan";
        contaPoupanca.Saldo = 3000;
        contaPoupanca.Juros = 0.02;

        contaCorrente.MostrarSaldo();
        contaCorrente.MostrarContaCorrente();

        contaPoupanca.MostrarSaldo();
        contaPoupanca.MostrarContaPoupanca();
    }
}