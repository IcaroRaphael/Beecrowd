double[] precos = new double[5] { 4.00, 4.50, 5.00, 2.00, 1.50 };

string[] entrada = Console.ReadLine().Split(' ');
int item = int.Parse(entrada[0]);
int quantidade = int.Parse(entrada[1]);

double precoTotal = quantidade * (precos[item - 1]);
Console.WriteLine($"Total: R$ {precoTotal:f2}");
