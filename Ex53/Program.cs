using System;

class Program
{
    static void Main()
    {
        string frase = "Estou estudando programação em C#";
        string palavra = "C#";

        bool contem = frase.Contains(palavra);

        Console.WriteLine($"Contém '{palavra}'? {contem}");
    }
}