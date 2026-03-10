class Program
{
    static void Main()
    {
        ContaPremium conta = new ContaPremium();

        conta.Titular = "Fernanda";
        conta.Saldo = 1000;
        conta.Limite = 500;

        conta.MostrarTipo();
        conta.Sacar(1200);
        conta.MostrarSaldo();
    }
}