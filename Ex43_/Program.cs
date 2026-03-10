class Program
{
    static void Main()
    {
        Livro l = new Livro();

        l.Nome = "Clean Code";
        l.Autor = "Robert Martin";

        l.MostrarLivro();
    }
}