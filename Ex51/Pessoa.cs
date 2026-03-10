using System;
using System.Collections.Generic;
using System.Text;

class Pessoa
{
    public string Nome;

    public virtual void Apresentar()
    {
        Console.WriteLine(Nome);
    }
}
