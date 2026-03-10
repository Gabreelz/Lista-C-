using System;
using System.Collections.Generic;
using System.Text;

public class Desenvolvedor : Funcionario
{
    public double Horas { get; set; }
    public double ValorHora { get; set; }

    public Desenvolvedor(string nome, double horas, double valorHora) : base(nome)
    {
        Horas = horas;
        ValorHora = valorHora;
    }

    public override double CalcularSalario()
    {
        return Horas * ValorHora;
    }
}
