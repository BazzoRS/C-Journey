
// Declaring nullable by using standard: Nullable<T> var = null
Console.WriteLine("Nullable declaration result");
Nullable<int> var1 = null; //Nullable command turns all types to start accepting the null state
Console.WriteLine(var1);

// Instead of using long text, use simplified nullable statment by: ?T var = null;

Console.WriteLine("Simplified verstion of nullable declaration");
int? var2 = null;
Console.WriteLine(var2);

int? var3 = var2 ?? 0; // If var2 = 0 return 0, else retunrn var2;

Console.WriteLine(var3);

Console.ReadLine();

int? var4 = var3 + var2; // O mesmo se aplica a resultados de expressões que resultam em null

Console.WriteLine(var4);

Console.ReadLine();

int? var5 = 100;

    if (var5.HasValue)
    {
        Console.WriteLine($"b = {var5.Value}");

    }
    else
    {
        Console.WriteLine("b não possui valor");
    }