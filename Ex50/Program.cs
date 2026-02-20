using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercicio 50");

        String str50 = "Frase Aleatoria";

        String strNova50 = str50.Replace("a", "@");

        Console.WriteLine("A string original é: " + str50);
        Console.WriteLine("A string modificada é: " + strNova50 + "\n");

    }
}