using System;

public class Produto
{
    public string Nome { get; set; }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Preco", "O preço deve ser maior que zero.");

            preco = value;
        }
    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void AplicarDesconto(double percentual)
    {
        if (percentual < 0 || percentual > 100)
            throw new ArgumentOutOfRangeException("percentual", "O percentual deve estar entre 0 e 100.");

        Preco -= Preco * (percentual / 100);
    }
}
