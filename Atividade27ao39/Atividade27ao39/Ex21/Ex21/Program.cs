public class Carro
{
    public int Velocidade { get; private set; }

    public void Acelerar()
    {
        Velocidade += 10;
        Console.WriteLine("Acelerando... Velocidade atual: " + Velocidade);
    }
}