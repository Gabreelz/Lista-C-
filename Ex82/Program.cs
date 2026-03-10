class Program
{
    static void Main()
    {
        Relatorio r = new Relatorio(1, "Relatório Financeiro", "123");

        if (r.Autenticar("123"))
        {
            r.Imprimir();
        }
    }
}