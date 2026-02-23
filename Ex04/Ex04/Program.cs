int numero  = 3;
int numero2 = 5;
int numero3 = 1;

if (numero > numero2 && numero > numero3)
{
    Console.WriteLine("O maior número é: " + numero);
}
else if (numero2 > numero && numero2 > numero3)
{
    Console.WriteLine("O maior número é: " + numero2);
}
else
{
    Console.WriteLine("O maior número é: " + numero3);
}
