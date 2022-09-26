Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("----Vivendo de dividendos----");
Console.ResetColor();

Console.Write("\nGastos mensais (em R$): ");
decimal gastos = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimentos mensais (%): ");
decimal rendimentos = Convert.ToDecimal(Console.ReadLine());

decimal resultado = gastos/(rendimentos/100);


Console.WriteLine($"\nPara receber {gastos:C} por mês com rendimentos de {rendimentos:N1}% você precisa ter investido {resultado:C}.\n");

