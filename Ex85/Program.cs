class Program
{
    static void Main()
    {
        Relatorio r = new Relatorio("Relatório Financeiro");

        Impressora impressora = new Impressora();

        impressora.ImprimirDocumento(r);
    }
}