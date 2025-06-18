string[] valores = Console.ReadLine().Split(' ');

double num1 = double.Parse(valores[0]);
double num2 = double.Parse(valores[1]);
double num3 = double.Parse(valores[2]);
double num4 = double.Parse(valores[3]);

double media = ((num1 * 2) + (num2 * 3) + (num3 * 4) + (num4 * 1)) / (2 + 3 + 4 + 1);

Console.WriteLine($"Media: {media:f1}");

if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (media < 7 && media >= 5)
{
    Console.WriteLine("Aluno em exame.");
    Console.Write("Nota do exame: ");
    double recuperacao = double.Parse(Console.ReadLine());
    double mediaFinal = (recuperacao + media) / 2;
    if (mediaFinal >= 5)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else if (mediaFinal < 5)
    {
        Console.WriteLine("Aluno reprovado.");
    }
    Console.WriteLine($"Media final: {mediaFinal:f1}");
}
else if (media < 5)
{
    Console.WriteLine("Aluno reprovado.");
}
