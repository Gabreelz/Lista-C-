using System;

class Program
{
    static void Main()
    {
        DateTime hoje = DateTime.Now;

        DateTime fimDoAno = new DateTime(hoje.Year, 12, 31);

        TimeSpan diferenca = fimDoAno - hoje;

        Console.WriteLine("Dias restantes até o final do ano: " + diferenca.Days);
    }
}