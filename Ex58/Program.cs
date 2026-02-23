using System;

class Program
{
    static void Main()
    {

        DateTime dataAtual = DateTime.Now;

        DateTime novaData = dataAtual.AddDays(30);

        Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy"));
        Console.WriteLine("Nova data (+30 dias): " + novaData.ToString("dd/MM/yyyy"));
    }
}