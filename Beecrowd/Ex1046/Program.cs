string[] entrada = Console.ReadLine().Split(' ');

int inicio = int.Parse(entrada[0]);
int fim = int.Parse(entrada[1]);

if(fim == inicio)
{
    int duracao = 24;
    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
}
else if(fim > inicio)
{
    int duracao = fim - inicio;
    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
}
else if(fim < inicio)
{
    int duracao = (24 - inicio) + fim;
    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
}
