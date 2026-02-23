double lado1 = 5;
double lado2 = 7;
double lado3 = 5;

if (lado1 + lado2 > lado3 &&
    lado1 + lado3 > lado2 &&
    lado2 + lado3 > lado1)
{
    Console.Write("Os valores formam um triângulo do tipo: ");

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Isósceles");
    }
    else
    {
        Console.WriteLine("Escaleno");
    }
}
else
{
    Console.WriteLine("Os valores NÃO formam um triângulo.");
}