Dictionary<string, double> notas = new Dictionary<string, double> { { "Ana", 9.5 }, { "Bia", 10.0 } };

if (notas.ContainsKey("Ana"))
{
    Console.WriteLine($"A nota da Ana é: {notas["Ana"]}");
}