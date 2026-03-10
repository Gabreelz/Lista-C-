using System;
using System.Collections.Generic;
using System.Text;

class Funcionario : Pessoa
{
    public Funcionario(string nome) : base(nome)
    {
    }

    public void MostrarNome()
    {
        Console.WriteLine("Funcionário: " + nome);
    }
}

