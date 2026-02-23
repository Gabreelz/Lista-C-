using System;

class Program
{
    static void Main()
    {
        DateTime dataNascimento = new DateTime(2000, 5, 10);

        int idade = CalcularIdade(dataNascimento);

        Console.WriteLine($"Idade: {idade} anos");
    }

    static int CalcularIdade(DateTime dataNascimento)
    {
        DateTime hoje = DateTime.Today;

        int idade = hoje.Year - dataNascimento.Year;

        if (dataNascimento.Date > hoje.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }
}