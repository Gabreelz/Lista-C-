using System;
using System.Collections.Generic;
using System.Text;

    class Aluno : Pessoa
    {
        public int Idade;

        public Aluno(string nome, int idade) : base(nome)
        {
            Idade = idade;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }

