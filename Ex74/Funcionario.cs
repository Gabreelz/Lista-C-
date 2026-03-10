using System;
using System.Collections.Generic;
using System.Text;

public abstract class Funcionario
{
    public string Nome { get; set; }

    protected Funcionario(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();

    public virtual void ExibirDados()
    {
        Console.WriteLine("Funcionário: " + Nome);
    }
}
