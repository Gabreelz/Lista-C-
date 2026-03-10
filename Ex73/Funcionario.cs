using System;
using System.Collections.Generic;
using System.Text;

abstract class Funcionario
{
    public string Nome { get; set; }

    protected public Funcionario(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();
}
