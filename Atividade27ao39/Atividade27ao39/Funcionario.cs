public class Funcionario
{
    private string nome;
    private double salario;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Salario
    {
        get { return salario; }
        set
        {
            if (value > 0)
                salario = value;
        }
    }
}