using System;

class Program
{
    static void Main()
    {
        string texto = "Programacao";

        string invertida = InverterString(texto);

        Console.WriteLine($"Original: {texto}");
        Console.WriteLine($"Invertida: {invertida}");
    }

    static string InverterString(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}