Console.WriteLine("===== MENU =====");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multiplicar");
Console.Write("Escolha uma opção: ");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu SOMAR.");
        break;

    case 2:
        Console.WriteLine("Você escolheu SUBTRAIR.");
        break;

    case 3:
        Console.WriteLine("Você escolheu MULTIPLICAR.");
        break;
}