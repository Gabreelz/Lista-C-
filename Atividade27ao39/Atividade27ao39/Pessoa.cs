public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public string Apresentar()
    {
        return $"Olá, meu nome é {Nome} e tenho {Idade} anos.";
    }
}