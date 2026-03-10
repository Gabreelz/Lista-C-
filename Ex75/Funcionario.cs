using System;
using System.Collections.Generic;
using System.Text;

public abstract class Funcionario : IBonus
{
    public string Nome { get; set; }

    protected Funcionario(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();

    // método da interface (ainda abstrato)
    public abstract double CalcularBonus();

    public virtual void ExibirDados()
    {
        Console.WriteLine("Funcionário: " + Nome);
    }
}