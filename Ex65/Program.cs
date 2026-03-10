class Program
{
    static void Main()
    {
        List<Forma> formas = new List<Forma>();

        formas.Add(new Quadrado(4));
        formas.Add(new Circulo(3));
        formas.Add(new Quadrado(2));

        foreach (Forma forma in formas)
        {
            Console.WriteLine("Área: " + forma.CalcularArea());
        }
    }
}