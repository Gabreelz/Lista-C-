string entrada = "1000";
bool sucesso = int.TryParse(entrada, out int resultado);

Console.WriteLine($"Conversão funcionou? {sucesso}. Valor: {resultado}");