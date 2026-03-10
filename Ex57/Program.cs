class Program
{
    static void Main()
    {
        ContaPremium premium = new ContaPremium();
        premium.Titular = "Julia";

        Conta conta = premium;
        Console.WriteLine("Titular: " + conta.Titular);

        ContaCorrente corrente = (ContaCorrente)conta;
        corrente.MostrarTipo();
    }
}