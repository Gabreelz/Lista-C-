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
        contaCorrente.Saldo = 1000;
        contaCorrente.Sacar(100);
        contaCorrente.MostrarSaldo();

        contaPoupanca.MostrarSaldo();
        contaPoupanca.MostrarContaPoupanca();
        contaPoupanca.Saldo = 200;
        contaPoupanca.Sacar(300);
        contaPoupanca.MostrarSaldo();
    }
}