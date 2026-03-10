class Program
{
    static void Main()
    {
        Funcionario f1 = new Gerente("Ana", 5000);
        Funcionario f2 = new Desenvolvedor("Carlos", 160, 50);

        Console.WriteLine(f1.CalcularSalario());
        Console.WriteLine(f1.CalcularBonus());

        Console.WriteLine(f2.CalcularSalario());
        Console.WriteLine(f2.CalcularBonus());
    }
}