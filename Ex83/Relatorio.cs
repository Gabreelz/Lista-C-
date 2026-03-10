using System;
using System.Collections.Generic;
using System.Text;


public class Relatorio : IAutenticavel, IImprimivel, IIdentificavel, IValidavel
{
    public int Id { get; set; }
    public string Titulo { get; set; }

    private string Senha { get; set; }

    public Relatorio(int id, string titulo, string senha)
    {
        Id = id;
        Titulo = titulo;
        Senha = senha;
    }

    public bool Autenticar(string senha)
    {
        return senha == Senha;
    }

    public void Imprimir()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Relatório: " + Titulo);
    }

    public bool Validar()
    {
        return !string.IsNullOrEmpty(Titulo);
    }
}