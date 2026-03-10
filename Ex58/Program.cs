class Program
{
    static void Main()
    {
        Conta conta = new ContaCorrente();
        conta.Titular = "Pedro";

        // usando IS
        if (conta is ContaCorrente)
        {
            Console.WriteLine("A conta é do tipo ContaCorrente");
        }

        // usando AS
        ContaCorrente cc = conta as ContaCorrente;

        if (cc != null)
        {
            cc.MostrarTipo();
        }
    }
}