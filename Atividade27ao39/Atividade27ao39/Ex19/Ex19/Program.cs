public class Usuario
{
    public static int TotalUsuarios { get; private set; }

    public Usuario()
    {
        TotalUsuarios++;
    }
}