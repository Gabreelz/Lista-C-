List<int> numeros = new List<int> { -2, 5, 3, -1, 8 };
int positivos = 0;

foreach (int n in numeros)
{
    if (n > 0)
        positivos++;
}

Console.WriteLine(positivos);