string numero = "abc";
int resultado;

bool sucesso = int.TryParse(numero, out resultado);

Console.WriteLine(sucesso);
