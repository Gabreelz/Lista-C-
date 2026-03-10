class Program
{
    static void Main()
    {
        Consumo c = new Consumo();
        c.Combustivel = 50;

        double consumo = c.CalcularConsumo();

        Console.WriteLine("Consumo: " + consumo);
    }
}