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

        Gerente gerente = new Gerente();

        gerente.Nome = "Ana";
        gerente.Idade = 40;
        gerente.Salario = 9000;
        gerente.Departamento = "TI";

        gerente.Dados();
        gerente.MostrarFuncionario();
        gerente.MostrarGerente();
    }
}