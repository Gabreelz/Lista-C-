public class Quadrado
{
    public double Lado { get; set; }
    // Não armazena valor, calcula toda vez que é acessada
    public double Area => Lado * Lado;
}