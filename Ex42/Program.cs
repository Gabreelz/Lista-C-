class Program
{
    static void Main()
    {
        Consumo c = new Carro();

        Console.WriteLine("Consumo do carro: " + c.CalcularConsumo());
    }
}