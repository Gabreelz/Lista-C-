class Program
{
    static void Main()
    {
        Conta conta;

        conta = new ContaCorrente();
        conta.Titular = "Peter";
        conta.MostrarTipo();

        conta = new ContaPoupanca();
        conta.Titular = "Steve";
        conta.MostrarTipo();
    }
}