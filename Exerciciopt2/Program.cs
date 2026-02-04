
Console.WriteLine("Digite 2 valores");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Soma é igual a: {x + y}");
Console.WriteLine($"Subtração é igual a: {x - y}");
Console.WriteLine($"Multiplicação é igual a: {x * y}");
Console.WriteLine($"Exponenciação é igual a: {Math.Pow(x, y)}");
Console.WriteLine($"Divisão é igual a: {x / y}");
Console.WriteLine($"Módulo é igual a: {x % y}");

Console.ReadKey();

