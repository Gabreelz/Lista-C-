class Program
{
    static void Main()
    {
        Relatorio relatorio = new Relatorio("Relatório Financeiro", "123");

        if (relatorio.Autenticar("123"))
        {
            relatorio.Imprimir();
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }
}