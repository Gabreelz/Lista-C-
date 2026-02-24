var estoque = new Dictionary<string, int> { { "Maçã", 50 }, { "Uva", 20 } };

foreach (KeyValuePair<string, int> item in estoque)
{
    Console.WriteLine($"Produto: {item.Key} | Qtd: {item.Value}");
}