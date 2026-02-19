string numero = "250";
int resultado;

bool sucesso = int.TryParse(numero, out resultado);

Console.WriteLine(sucesso);
Console.WriteLine(resultado);
