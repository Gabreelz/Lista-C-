using System;
using System.Collections.Generic;
using System.Text;

sealed class Livro : Produto
{
    public string Autor;

    public void MostrarLivro()
    {
        Console.WriteLine("Livro: " + Nome);
        Console.WriteLine("Autor: " + Autor);
    }
}