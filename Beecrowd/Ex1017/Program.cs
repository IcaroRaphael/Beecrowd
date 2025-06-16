int tempo = int.Parse(Console.ReadLine());
int velocidadeMedia = int.Parse(Console.ReadLine());
int distancia = tempo * velocidadeMedia;
double litros = (double) distancia / 12;
Console.WriteLine($"{litros:f3}");
