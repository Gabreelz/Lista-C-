using System;

class Program
{
    static void Main()
    {
        DateTime hoje = DateTime.Now;

        string dataFormatada = hoje.ToString("dd/MM/yyyy");

        Console.WriteLine($"Data atual: {dataFormatada}");
    }
}