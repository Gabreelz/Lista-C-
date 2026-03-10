class Program
{
    static void Main()
    {
        Funcionario funcionario1 = new Gerente("Ana", 5000);
        Funcionario funcionario2 = new Desenvolvedor("Carlos", 160, 50);

        funcionario1.ExibirDados();
        Console.WriteLine(funcionario1.CalcularSalario());

        funcionario2.ExibirDados();
        Console.WriteLine(funcionario2.CalcularSalario());
    }
}