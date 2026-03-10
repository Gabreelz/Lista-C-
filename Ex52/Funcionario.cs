using System;
using System.Collections.Generic;
using System.Text;

class Funcionario : Pessoa
{
    public string Cargo;

    public override void Apresentar()
    {
        base.Apresentar();

        Console.WriteLine("Trabalho como " + Cargo);
    }
}
