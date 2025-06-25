using System.Collections.Generic;

string[] entrada = Console.ReadLine().Split(' ');

List<int> valoresOrdemCrescente = new List<int>();
List<int> temp = new List<int>();

//Adicionando todos os valores em uma lista temporária
foreach (var item in entrada)
{
    temp.Add(int.Parse(item));
}

//Lógica para ordenação
for (int i = 0; i < entrada.Length; i++)
{
    int menor = 0;
    int j = 0;
    for (j = 0; j < temp.Count; j++)
    {
        if (j == 0)
        {
            menor = temp[j];
        }
        else if (temp[j] < menor)
        {
            menor = temp[j];
        }
    }
    valoresOrdemCrescente.Add(menor);
    temp.Remove(menor);
}

//Print no console
foreach (var v in valoresOrdemCrescente)
{
    Console.WriteLine(v);
}
Console.WriteLine();
foreach (var e in entrada)
{
    Console.WriteLine(e);
}
