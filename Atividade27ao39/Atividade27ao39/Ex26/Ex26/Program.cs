public class Mensageiro
{
    public void Enviar(string msg, string prefixo = "LOG")
    {
        Console.WriteLine($"[{prefixo}]: {msg}");
    }
}