using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 10, 20, 30, 40 };

        int resultado = SomarLista(numeros);

        Console.WriteLine($"Soma total: {resultado}");
    }

    static int SomarLista(List<int> lista)
    {
        int soma = 0;

        foreach (int numero in lista)
        {
            soma += numero;
        }

        return soma;
    }
}