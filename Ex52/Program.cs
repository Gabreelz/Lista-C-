class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario();

        funcionario.Nome = "Gabriel";
        funcionario.Cargo = "Desenvolvedor";

        funcionario.Apresentar();
    }
}