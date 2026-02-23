List<int> numeros = new List<int> { 10, 25, 7, 40, 3 };
int maior = numeros[0];

foreach (int n in numeros)
{
    if (n > maior)
        maior = n;
}

Console.WriteLine(maior);