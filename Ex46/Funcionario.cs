using System;
using System.Collections.Generic;
using System.Text;

class Funcionario : Pessoa
{
    public double Salario;

    public void MostrarFuncionario()
    {
        Console.WriteLine("Salário: " + Salario);
    }
}
