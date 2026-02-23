using System;

class Program
{
    static void Main()
    {
        string texto = "programacao em c#";

        string maiusculo = texto.ToUpper();

        Console.WriteLine("Original: " + texto);
        Console.WriteLine("Maiúsculo: " + maiusculo);
    }
}