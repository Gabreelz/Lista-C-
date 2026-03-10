using System;
using System.Collections.Generic;
using System.Text;
public class Pagamento
{
    public int Id { get; set; }
    public double Valor { get; set; }

    public Pagamento(int id, double valor)
    {
        Id = id;
        Valor = valor;
    }

    public virtual void ExibirPagamento()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Valor: " + Valor);
    }
}