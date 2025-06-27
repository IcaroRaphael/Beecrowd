string[] entrada = Console.ReadLine().Split(' ');

double lado1 = double.Parse(entrada[0]);
double lado2 = double.Parse(entrada[1]);
double lado3 = double.Parse(entrada[2]);

if (((lado1 + lado2) > lado3) && ((lado1 + lado3) > lado2) && ((lado2 + lado3) > lado1))
{
    Console.WriteLine($"Perimetro = {(lado1 + lado2 + lado3):f1}");
}
else
{
    Console.WriteLine($"Area = {((lado1 + lado2) * lado3 / 2):f1}");
}
