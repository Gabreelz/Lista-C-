class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario();

        funcionario.Nome = "Marcos";
        funcionario.Idade = 30;
        funcionario.Salario = 4500;

        funcionario.Dados();
        funcionario.MostrarFuncionario();
    }
}