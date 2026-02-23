double peso = 70;     
double altura = 1.75; 

double imc = peso / (altura * altura);

Console.WriteLine($"IMC: {imc:F2}");

if (imc < 18.5)
{
    Console.WriteLine("Classificação: Abaixo do peso");
}
else if (imc < 25)
{
    Console.WriteLine("Classificação: Peso normal");
}
else if (imc < 30)
{
    Console.WriteLine("Classificação: Sobrepeso");
}