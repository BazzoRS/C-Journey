var i = 1;

while (i <= 10)
{
    Console.WriteLine($"Counter is equal to: {i}");
    i++;
}

Console.WriteLine("Digite um numero!");
int n = Convert.ToInt32(Console.ReadLine());
int c = 1;

if (n > 0)

{

    while (c < 11)
    {

        Console.WriteLine($"O Valor da tabuada é:{n * c++}");

    }

}
else
{

    Console.WriteLine("Numero menor que 0");

}