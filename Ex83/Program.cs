class Program
{
    static void Main()
    {
        Relatorio relatorio = new Relatorio(1, "Relatório Financeiro", "123");

        if (relatorio.Validar())
        {
            if (relatorio.Autenticar("123"))
            {
                relatorio.Imprimir();
            }
        }
    }
}