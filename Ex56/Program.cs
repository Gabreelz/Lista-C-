using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercicio 56");
        String num56 = "12345";
        String num562 = "678910";

        int valorNum56 = int.Parse(num56);
        int valorNum562 = int.Parse(num562);

        Console.WriteLine("Valor do número 1: " + valorNum56);
        Console.WriteLine("Valor do número 2: " + valorNum562);
        Console.WriteLine("Soma dos números: " + (valorNum56 + valorNum562) + "\n");

    }
}