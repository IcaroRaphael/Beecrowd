string nomeVendedor = Console.ReadLine();
double salarioFixoVendedor = double.Parse(Console.ReadLine());
double vendasVendedor = double.Parse(Console.ReadLine());

double salarioFinalVendedor = (0.15 * vendasVendedor) + salarioFixoVendedor;

System.Console.WriteLine($"TOTAL = R$ {salarioFinalVendedor:F2}");
