using System;

class Program
{
    static void Main()
    {
        Funcionario f1 = new Gerente("Tony", 5000);
        Funcionario f2 = new Desenvolvedor("Peter", 160, 50);

        Console.WriteLine("Salário Gerente: " + f1.CalcularSalario());
        Console.WriteLine("Salário Desenvolvedor: " + f2.CalcularSalario());
    }
}