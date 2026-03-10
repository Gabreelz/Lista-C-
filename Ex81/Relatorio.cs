using System;
using System.Collections.Generic;
using System.Text;

public class Relatorio : IAutenticavel, IImprimivel
{
    public string Titulo { get; set; }
    private string Senha { get; set; }

    public Relatorio(string titulo, string senha)
    {
        Titulo = titulo;
        Senha = senha;
    }

    public bool Autenticar(string senha)
    {
        return senha == Senha;
    }

    public void Imprimir()
    {
        Console.WriteLine("Imprimindo relatório: " + Titulo);
    }
}
