using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Produto p = new Produto
        {
            Nome = "Notebook",
            Preco = 3500
        };

        Console.WriteLine($"Produto: {p.Nome} - {p.Preco}");

        Cliente cliente = new Cliente("Felipe", 22, "felipe@email.com");
        Console.WriteLine(cliente);

        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Carlos";
        pessoa.Idade = 30;

        Console.WriteLine(pessoa.Apresentar());

        Funcionario f = new Funcionario();
        f.Nome = "Maria";
        f.Salario = 5000;

        Console.WriteLine($"Funcionario: {f.Nome} - {f.Salario}");

        List<Animal> animais = new List<Animal>();

        animais.Add(new Cachorro());
        animais.Add(new Gato());

        foreach (Animal a in animais)
        {
            a.EmitirSom();
        }

        Carro carro = new Carro();
        carro.Marca = "Toyota";
        carro.Portas = 4;

        Moto moto = new Moto();
        moto.Marca = "Honda";
        moto.Cilindradas = 600;

        Console.WriteLine($"Carro: {carro.Marca} - {carro.Portas} portas");
        Console.WriteLine($"Moto: {moto.Marca} - {moto.Cilindradas}cc");
    }
}