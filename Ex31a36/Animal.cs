using System;

public class Animal
{
    public string Nome { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal fazendo som");
    }
}