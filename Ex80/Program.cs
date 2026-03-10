class Program
{
    static void Main()
    {
        Administrador admin = new Administrador("Admin", "1234");

        if (admin.Autenticar("1234"))
            Console.WriteLine("Administrador autenticado");
        else
            Console.WriteLine("Senha incorreta");



        Cliente cliente = new Cliente("João", "abcd");

        if (cliente.Autenticar("abcd"))
            Console.WriteLine("Cliente autenticado");
        else
            Console.WriteLine("Senha incorreta");
    }

}