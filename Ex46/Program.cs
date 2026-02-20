using System;

class Program
{
    static void Main()
    {
        //Ex 46
        decimal salario = 2300;

        decimal aumento = salario * 0.10m;

        decimal salarioFinal = salario + aumento;

        Console.WriteLine("Exercicio 46");
        Console.WriteLine($"O salário inicial é: {salario}");
        Console.WriteLine($"O aumento é: {aumento}");
        Console.WriteLine($"O salário final é: {salarioFinal}\n");
    }
}

