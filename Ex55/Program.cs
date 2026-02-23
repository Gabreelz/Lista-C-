using System;

class Program
{
    static void Main()
    {
        string texto = "Programacao";

        string primeirosTres = texto.Substring(0, 3);

        Console.WriteLine($"Texto original: {texto}");
        Console.WriteLine($"Primeiros 3 caracteres: {primeirosTres}");
    }
}