using System;
using System.Collections.Generic;
using System.Text;

class Gerente : Funcionario
{
    public double SalarioBase { get; set; }

    public Gerente(string nome, double salarioBase) : base(nome)
    {
        SalarioBase = salarioBase;
    }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.2;
    }
}