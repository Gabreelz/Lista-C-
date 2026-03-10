using System;
using System.Collections.Generic;
using System.Text;

abstract class Funcionario
{
    public string Nome { get; set; }
    public abstract double CalcularSalario();
}
