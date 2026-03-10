using System;
using System.Collections.Generic;
using System.Text;

using System;

public class Cliente : IAutenticavel
{
    public string Nome { get; set; }
    private string Senha { get; set; }

    public Cliente(string nome, string senha)
    {
        Nome = nome;
        Senha = senha;
    }

    public bool Autenticar(string senha)
    {
        return senha == Senha;
    }
}