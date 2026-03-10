using System;

class Program
{
    static void Main()
    {
        Gerente gerente = new Gerente("Ana", 5000);
        Desenvolvedor dev = new Desenvolvedor("Carlos", 160, 50);

        Console.WriteLine(gerente.CalcularSalario());
        Console.WriteLine(dev.CalcularSalario());
    }
}