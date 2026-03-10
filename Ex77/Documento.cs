using System;
using System.Collections.Generic;
using System.Text;

using System;

public class Documento : IImprimivel
{
    public string Titulo { get; set; }
    public string Conteudo { get; set; }

    public Documento(string titulo, string conteudo)
    {
        Titulo = titulo;
        Conteudo = conteudo;
    }

    public void Imprimir()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Conteúdo: " + Conteudo);
    }
}
