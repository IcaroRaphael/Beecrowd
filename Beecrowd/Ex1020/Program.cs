int dias = int.Parse(Console.ReadLine());

int ano = 0;
int mes = 0;
int dia = 0;

int resto = dias;

if (resto >= 365)
{
    ano = resto / 365;
    resto = resto - (ano * 365);
}
if (resto >= 30)
{
    mes = resto / 30;
    resto = resto - (mes * 30);
}
if (resto > 0)
{
    dia = resto;
}

Console.WriteLine($"{ano} ano(s)");
Console.WriteLine($"{mes} mes(es)");
Console.WriteLine($"{dia} dia(s)");
