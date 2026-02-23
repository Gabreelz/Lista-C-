using System;

class Program
{
    static void Main()
    {
        DateTime data1 = new DateTime(2025, 2, 1);
        DateTime data2 = new DateTime(2025, 2, 23);

        TimeSpan diferenca = data2 - data1;

        Console.WriteLine($"Diferença em dias: {diferenca.Days}");
        Console.WriteLine($"Diferença total em horas: {diferenca.TotalHours}");
    }
}