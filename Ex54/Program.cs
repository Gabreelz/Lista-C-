using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercicio 54");
        decimal num54 = 123.456m;
        decimal arredondado54 = Math.Round(num54);
        int arredondadoInt54 = (int)arredondado54;
        Console.WriteLine("Número original: " + num54);
        Console.WriteLine("Número arredondado: " + arredondado54);
        Console.WriteLine("Número arredondado convertido para int: " + arredondadoInt54 + "\n");

    }
}