string entradaInvalida = "dez";
bool sucesso = int.TryParse(entradaInvalida, out int resultado);

if (sucesso)
{
    Console.WriteLine($"Valor: {resultado}");
}
else
{
    Console.WriteLine("Erro: 'dez' não é um número inteiro válido.");
}
