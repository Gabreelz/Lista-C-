using System;

public class Aluno
{
    public double Nota { get; set; }

    public Aluno(double nota)
    {
        Nota = nota;
    }

    public bool Aprovado()
    {
        return Nota >= 7.0;
    }
}