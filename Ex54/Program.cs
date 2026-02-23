using System;

class Program
{
    static void Main()
    {
        string frase = "Eu gosto de Java";

        string novaFrase = frase.Replace("Java", "C#");

        Console.WriteLine("Original: " + frase);
        Console.WriteLine("Modificada: " + novaFrase);
    }
}