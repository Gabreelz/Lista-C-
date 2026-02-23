using System;

class Program
{
    static void Main()
    {
        DateTime data = DateTime.Now; 
        bool ehFimDeSemana =
            data.DayOfWeek == DayOfWeek.Saturday ||
            data.DayOfWeek == DayOfWeek.Sunday;

        if (ehFimDeSemana)
            Console.WriteLine("É fim de semana.");
        else
            Console.WriteLine("Não é fim de semana.");
    }
}