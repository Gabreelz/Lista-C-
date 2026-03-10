public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public override string ToString()
    {
        return $"Produto: {Nome}, Preço: {Preco:C}";
    }
}