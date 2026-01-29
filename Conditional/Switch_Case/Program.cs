Console.WriteLine("\nPurchase Net value is $600");
Console.WriteLine("\nEnter the payment stack");
var prestacao = Convert.ToInt32(Console.ReadLine());

switch (prestacao)
{

    case 1:

        Console.WriteLine($"\n Valor da prestação é de R$ {600 / prestacao}");
        break;

    case 2:

        Console.WriteLine($"\n Valor da prestação é de R$ {600 / prestacao}");
        break;

    case 3:

        Console.WriteLine($"\n Valor da prestação é de R$ {600 / prestacao}");
        break;

}


Console.WriteLine("\nConsole Par or Impar");
Console.WriteLine("\nEnter the num value");
int number = Convert.ToInt32(Console.ReadLine());

switch (number % 2) // switch doesn't undestand bool types!!!
{

    case 0:

        Console.WriteLine($"\n{number} é par!");
        break;

    case 1:

        Console.WriteLine($"\n{number} é impar!");
        break;


}