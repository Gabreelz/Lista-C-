List<Produto> carrinho = new List<Produto>();
carrinho.Add(new Produto("Mouse", 59.90));
carrinho.Add(new Produto("Teclado", 120.00));

foreach (var p in carrinho)
{
    Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
}

public record Produto(string Nome, double Preco);