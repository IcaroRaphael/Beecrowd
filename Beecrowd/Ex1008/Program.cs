int numeroFuncionario = int.Parse(Console.ReadLine());
int horasTrabalhadas = int.Parse(Console.ReadLine());
double valorPorHora = double.Parse(Console.ReadLine());

double salario = horasTrabalhadas * valorPorHora;

System.Console.WriteLine($"NUMBER = {numeroFuncionario}");
System.Console.WriteLine($"SALARY = U$ {salario:F2}");
