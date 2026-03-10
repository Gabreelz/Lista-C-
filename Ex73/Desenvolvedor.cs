using System;
using System.Collections.Generic;
using System.Text;


class Desenvolvedor : Funcionario
{
    public double HorasTrabalhadas { get; set; }
    public double ValorHora { get; set; }

    public Desenvolvedor(string nome, double horas, double valorHora) : base(nome)
    {
        HorasTrabalhadas = horas;
        ValorHora = valorHora;
    }

    public override double CalcularSalario()
    {
        return HorasTrabalhadas * ValorHora;
    }
}