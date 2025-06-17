decimal entrada = decimal.Parse(Console.ReadLine());

decimal[] notas = new decimal[6] { 100.00M, 50.00M, 20.00M, 10.00M, 5.00M, 2.00M };
decimal[] moedas = new decimal[6] { 1.00M, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };

decimal resto = entrada;

Console.WriteLine("NOTAS:");
foreach (var nota in notas)
{
    int quantNotas = (int)(resto / nota);
    resto = resto - (quantNotas * nota);
    Console.WriteLine($"{quantNotas} nota(s) de R$ {nota:f2}");
}

Console.WriteLine("MOEDAS:");
foreach (var moeda in moedas)
{
    int quantMoedas = (int)(resto / moeda);
    resto = resto - (quantMoedas * moeda);
    Console.WriteLine($"{quantMoedas} moeda(s) de R$ {moeda:f2}");
}
