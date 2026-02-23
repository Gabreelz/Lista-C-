List<int> numeros = new List<int> { 7, 8, 9 };
double soma = 0;

foreach (int n in numeros)
{
    soma += n;
}

double media = soma / numeros.Count;
Console.WriteLine(media);