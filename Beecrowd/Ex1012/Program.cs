using System;

class URI
{

    static void Main(string[] args)
    {
        const double PI = 3.14159;

        string[] entrada = Console.ReadLine().Split(' ');
        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);

        double areaDoTriangulo = a * c / 2.0;
        double areaDoCirculo = PI * Math.Pow(c, 2);
        double areaDoTrapezio = (a + b) * c / 2.0;
        double areaDoQuadrado = b * b;
        double areaDoRetangulo = a * b;

        Console.WriteLine($"TRIANGULO: {areaDoTriangulo:f3}");
        Console.WriteLine($"CIRCULO: {areaDoCirculo:f3}");
        Console.WriteLine($"TRAPEZIO: {areaDoTrapezio:f3}");
        Console.WriteLine($"QUADRADO: {areaDoQuadrado:f3}");
        Console.WriteLine($"RETANGULO: {areaDoRetangulo:f3}");

    }

}
