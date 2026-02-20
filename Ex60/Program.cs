using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercicio 60");
        string nome = "Fabricio";
        int idade = 18;
        decimal salario60 = 7000.50m;

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"Salário: R$ {salario60:F2}");
    }
}