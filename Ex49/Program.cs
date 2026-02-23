using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        List<int> pares = ObterPares(numeros);

        Console.WriteLine("Números pares:");
        foreach (int n in pares)
        {
            Console.WriteLine(n);
        }
    }

    static List<int> ObterPares(List<int> lista)
    {
        List<int> pares = new List<int>();

        foreach (int numero in lista)
        {
            if (numero % 2 == 0)
            {
                pares.Add(numero);
            }
        }

        return pares;
    }
}