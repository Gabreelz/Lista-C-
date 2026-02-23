using System;

class Program
{
    static void Main()
    {
        int numero = 10;

        Console.WriteLine($"Antes: {numero}");

        Dobrar(ref numero);

        Console.WriteLine($"Depois: {numero}");
    }

    static void Dobrar(ref int valor)
    {
        valor *= 2;
    }
}