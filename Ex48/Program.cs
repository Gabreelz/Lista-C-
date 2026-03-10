class Program
{
    static void Main()
    {
        Gerente gerente = new Gerente();

        gerente.Nome = "Ricardo";
        gerente.Salario = 8000;
        gerente.Departamento = "TI";

        Console.WriteLine("Nome: " + gerente.Nome);
        Console.WriteLine("Salário: " + gerente.Salario);
        Console.WriteLine("Departamento: " + gerente.Departamento);
    }
}