double lado1 = 5;
double lado2 = 7;
double lado3 = 10;

if (lado1 + lado2 > lado3 &&
    lado1 + lado3 > lado2 &&
    lado2 + lado3 > lado1)
{
    Console.WriteLine("formam um triangulo.");
}
else
{
    Console.WriteLine("nao formam um triangulo.");
}