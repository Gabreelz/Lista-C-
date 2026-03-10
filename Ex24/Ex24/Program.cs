public class Pedido
{
    private static int _contador = 1;
    public int Id { get; }

    public Pedido()
    {
        Id = _contador++;
    }
}
