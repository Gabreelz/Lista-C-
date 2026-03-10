using System;
using System.Collections.Generic;
using System.Text;

class Gerente : Funcionario
{
    public string Departamento;

    public void MostrarGerente()
    {
        Console.WriteLine("Departamento: " + Departamento);
    }
}
