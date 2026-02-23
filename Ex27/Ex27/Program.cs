List<int> numeros = new List<int> { 3, 4, 5 };
int soma = 0;

foreach (int n in numeros)
{
    soma += n;
}

Console.WriteLine(soma);