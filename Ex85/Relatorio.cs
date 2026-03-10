using System;
using System.Collections.Generic;
using System.Text;

public class Relatorio : IImprimivel
{
    public string Titulo { get; set; }

    public Relatorio(string titulo)
    {
        Titulo = titulo;
    }

    public void Imprimir()
    {
        Console.WriteLine("Relatório: " + Titulo);
    }
}