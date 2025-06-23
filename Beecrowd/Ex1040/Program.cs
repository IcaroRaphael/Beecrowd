string[] valores = Console.ReadLine().Split(' ');

double num1 = double.Parse(valores[0]);
double num2 = double.Parse(valores[1]);
double num3 = double.Parse(valores[2]);
double num4 = double.Parse(valores[3]);

double media = ((num1 * 2) + (num2 * 3) + (num3 * 4) + (num4 * 1)) / (2 + 3 + 4 + 1);

Console.WriteLine($"Media: {Math.Round(media,1):0.0}");

if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (media < 5)
{
    Console.WriteLine("Aluno reprovado.");
}
else if (media < 7 && media >= 5)
{
    Console.WriteLine("Aluno em exame.");
    double recuperacao = double.Parse(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {Math.Round(recuperacao, 1):0.0}");
    double mediaFinal = (recuperacao + media) / 2;
    if (mediaFinal >= 5)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else if (mediaFinal < 5)
    {
        Console.WriteLine("Aluno reprovado.");
    }
    Console.WriteLine($"Media final: {Math.Round(mediaFinal, 1):0.0}");
}
