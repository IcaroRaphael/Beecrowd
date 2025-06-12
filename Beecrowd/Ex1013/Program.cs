string[] entrada = Console.ReadLine().Split(' ');

int a = int.Parse(entrada[0]);
int b = int.Parse(entrada[1]);
int c = int.Parse(entrada[2]);

int primeiroMaior = (a + b + Math.Abs(a - b)) / 2;
int segundoMaior = (primeiroMaior + c + Math.Abs(primeiroMaior - c)) / 2;

Console.WriteLine($"{segundoMaior} eh o maior");
