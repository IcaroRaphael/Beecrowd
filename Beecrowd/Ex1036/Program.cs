string[] valores = Console.ReadLine().Split(' ');

double a = double.Parse(valores[0]);
double b = double.Parse(valores[1]);
double c = double.Parse(valores[2]);

double delta = (b * b) - (4 * a * c);
if (delta > 0 && a != 0)
{
    double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"R1 = {r1:f5}");
    Console.WriteLine($"R2 = {r2:f5}");
}
else if (delta == 0 && a != 0)
{
    double r = -b + Math.Sqrt(delta) / 2 * a;
    Console.WriteLine($"R = {r:f5}");
}
else
{
    Console.WriteLine("Impossivel calcular");
}
