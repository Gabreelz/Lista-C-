Console.Write("Digite a nota (A, B, C, D ou F): ");
char nota = char.ToUpper(Console.ReadKey().KeyChar);

Console.WriteLine();

switch (nota)
{
    case 'A':
        Console.WriteLine("Excelente!");
        break;

    case 'B':
        Console.WriteLine("Bom!");
        break;

    case 'C':
        Console.WriteLine("Regular.");
        break;

    case 'D':
        Console.WriteLine("Ruim.");
        break;

    case 'F':
        Console.WriteLine("Reprovado.");
        break;

    default:
        Console.WriteLine("Nota inválida.");
        break;
}