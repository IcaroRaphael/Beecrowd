using System;
using System.Globalization;
using System.Threading;

CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
Thread.CurrentThread.CurrentCulture = culturaBrasileira;
Thread.CurrentThread.CurrentUICulture = culturaBrasileira;

double entrada = double.Parse(Console.ReadLine());
Console.WriteLine($"{entrada:0}");

double resto = entrada;
int[] notas = new int[7]{ 100, 50, 20, 10, 5, 2, 1 };

foreach (var nota in notas)
{
    int quantNotas = (int)(resto / nota);
    resto = resto % nota;
    Console.WriteLine($"{quantNotas} nota(s) de R$ {nota:f2}");
}
