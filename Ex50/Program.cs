using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string senha = "Teste123!";

        bool valida = ValidarSenha(senha);

        Console.WriteLine($"Senha válida? {valida}");
    }

    static bool ValidarSenha(string senha)
    {
        if (string.IsNullOrEmpty(senha) || senha.Length < 8)
            return false;

        bool temMaiuscula = senha.Any(char.IsUpper);
        bool temMinuscula = senha.Any(char.IsLower);
        bool temNumero = senha.Any(char.IsDigit);
        bool temEspecial = senha.Any(c => !char.IsLetterOrDigit(c));

        return temMaiuscula && temMinuscula && temNumero && temEspecial;
    }
}