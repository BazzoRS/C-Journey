var a = 1;
var b = 12;
var c = -13;
var d = Math.Pow(b, 2) - 4 * a * c;
var x1 = (-b + Math.Sqrt(d)) / 2 * a;
var x2 = (-b - Math.Sqrt(d)) / 2 * a;


Console.WriteLine(x1);
Console.WriteLine(x2);


// Exercise phase 2
Console.WriteLine("Digite seu nome");
string name = Console.ReadLine();
Console.WriteLine("Digite sua senha");
int senha = Convert.ToInt32(Console.ReadLine());
var result = name == "admin" || name == "maria" && senha == 123 ? "login efetuado com sucesso" : "falha ao logar";
Console.WriteLine(result);

// Exercise phase 3

Console.WriteLine("Digite um numero para x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite um numero para y");
int y = Convert.ToInt32(Console.ReadLine());
var result1 = x % 2 == 0 ? "É par" : "É impar";
var result2 = y % 2 == 0 ? "É par" : "É impar";


Console.WriteLine($"\nX é: {result1}\nY {result2}");

//Exercise phase 4

Console.WriteLine("Digite um numero");
int numero = Convert.ToInt32(Console.ReadLine());

var formula1 = -6 + numero * 5;
var formula2 = (13 - 2) * numero;
var formula3 = (numero + -2) * (20 / numero);
var formula4 = (12 + numero) / (numero - 4);
var formula5 = 3 * Math.Pow(numero, 2) + numero + 10;
var formula6 = Math.PI * Math.Pow(numero, 2);

Console.WriteLine(formula1);
Console.WriteLine(formula2);
Console.WriteLine(formula3);
Console.WriteLine(formula4);
Console.WriteLine(formula5);
Console.WriteLine(formula6);

// Exercise phase 5

Console.WriteLine("Diga os celsius");
int celsius = Convert.ToInt32(Console.ReadLine());
var formulak = celsius + 273;
var formulaf = (celsius * 9) / 5 + 32;

Console.WriteLine($"\nTemperatura em Kelvin é {formulak} \nTemperatura em Farhenheit é {formulaf}");