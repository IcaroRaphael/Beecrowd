int tempoSegundos = int.Parse(Console.ReadLine());
int resto = tempoSegundos;

int horas = 0;
int minutos = 0;
int segundos = 0;

// Saber Horas
if (resto > 3600)
{
    horas = resto / 3600;
    resto = resto - (horas * 3600);
}

// Saber Minutos
if (resto > 60)
{
    minutos = resto / 60;
    resto = resto - (minutos * 60);
    
}

// Saber Segundos
segundos = resto;

Console.WriteLine($"{horas}:{minutos}:{segundos}");
