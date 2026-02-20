decimal precoOriginal = 100.00m;
decimal desconto = 0.15m; // 15%
decimal valorFinal = precoOriginal - (precoOriginal * desconto);

Console.WriteLine($"Valor com desconto: {valorFinal:C}");