using System;
using System.Collections.Generic;
using System.Text;

class Funcionario : Pessoa
{
    public string Cargo;

    public override void Apresentar()
    {
        Console.WriteLine( Nome + " Cargo " + Cargo);
    }
}
