using System; 

class URI {

    static void Main(string[] args)
    {
        double raio = double.Parse(Console.ReadLine());
        const double PI = 3.14159;
        double volume = (4.0 / 3) * PI * Math.Pow(raio, 3);
        Console.WriteLine($"VOLUME = {volume:f3}");
    }

}