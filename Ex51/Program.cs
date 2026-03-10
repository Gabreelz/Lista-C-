class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Lucas";
        pessoa.Apresentar();

        Funcionario funcionario = new Funcionario();
        funcionario.Nome = "Marina";
        funcionario.Cargo = "Analista";

        funcionario.Apresentar();
    }
}