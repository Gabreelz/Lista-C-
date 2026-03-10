using System;
using System.Collections.Generic;
using System.Text;

abstract class Funcionario
{
    public string Nome { get; set; }

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();
}
