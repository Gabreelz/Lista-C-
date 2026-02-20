string str1 = "Csharp";
string str2 = "csharp";
bool saoIguais = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);

Console.WriteLine($"As strings são iguais? {saoIguais}");