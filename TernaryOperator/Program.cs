// Uniario

int x = 10;

Console.WriteLine($"The uniary value of 10 using - is: {-x}");
Console.WriteLine("\nAgora informe um numero:");
var y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Seu numero agora negativo é {-y}");

// Ternário -> ?:  Condition ? expression1_if_true : expression2_if_false

Console.WriteLine("Digite a temperatura atual");
var temp = Convert.ToDouble(Console.ReadLine());
var result = temp > 27 ? "Hot" : "cold";

Console.WriteLine($"O tempo está {result}");

// Ternário -> ?:  Condition ? expression1_if_true : expression2_if_false for multiple conditions

Console.WriteLine("Digite a temperatura atual");
var temp1 = Convert.ToDouble(Console.ReadLine());
var result1 = temp1 > 27 ? "Normal" :
              temp1 < 27 ? "Frio" :
              temp1 == 27 ? "Diferente" : "Sem resultado" ;

Console.WriteLine($"O tempo está {result1}");

