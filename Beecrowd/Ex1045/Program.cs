//Transformando a entrada em um vetor de double
string[] entrada = Console.ReadLine().Split(' ');
double[] numerosDescrescente = new double[entrada.Length];
for(int j = 0; j < entrada.Length; j++)
{
    numerosDescrescente[j] = double.Parse(entrada[j]);
}

//Lógica da ordenação decrescente
for(int i = 0; i <  numerosDescrescente.Length; i++)
{
    int indiceMaior = 0;
    for(int j = i; j < numerosDescrescente.Length; j++)
    {
        if(j == i)
        {
            indiceMaior = j;
        }
        else if (numerosDescrescente[j] > numerosDescrescente[indiceMaior])
        {
            indiceMaior = j;
        }
    }

    double temp = numerosDescrescente[i];
    numerosDescrescente[i] = numerosDescrescente[indiceMaior];
    numerosDescrescente[indiceMaior] = temp;
}

//Verificações
double a = numerosDescrescente[0];
double b = numerosDescrescente[1];
double c = numerosDescrescente[2];
if (a >= (b + c))
{
    Console.WriteLine("NAO FORMA TRIANGULO");
}
else
{
    if ((a * a) == ((b * b) + (c * c)))
    {
        Console.WriteLine("TRIANGULO RETANGULO");
    }
    if ((a * a) > ((b * b) + (c * c)))
    {
        Console.WriteLine("TRIANGULO OBTUSANGULO");
    }
    if ((a * a) < ((b * b) + (c * c)))
    {
        Console.WriteLine("TRIANGULO ACUTANGULO");
    }
    if (a == b && b == c)
    {
        Console.WriteLine("TRIANGULO EQUILATERO");
    }
    if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
    {
        Console.WriteLine("TRIANGULO ISOSCELES");
    }
}
