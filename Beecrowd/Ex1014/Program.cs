double distancia = double.Parse(Console.ReadLine());
double consumo = double.Parse(Console.ReadLine());
double litros = distancia / consumo;
Console.WriteLine($"{litros:f3} km/l");
