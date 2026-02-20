using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercicio 52");

        int a52 = 15;
        int b52 = 10;

        if (a52 > b52)
        {
            Console.WriteLine($"{a52} é maior que {b52} \n");
        }
        else if (a52 < b52)
        {
            Console.WriteLine($"{b52} é maior que {a52} \n");
        }
        else
        {
            Console.WriteLine($"{a52} e {b52} são iguais \n");
        }

    }
}