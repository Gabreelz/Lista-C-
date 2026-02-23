List<string> palavras = new List<string> { "computador", "sol", "janela", "caderno" };
int contador = 0;

foreach (string p in palavras)
{
    if (p.Length > 5)
        contador++;
}

Console.WriteLine(contador);