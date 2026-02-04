
//Giving float, double and decimal values
Console.WriteLine("Atribuindo valores a double, float e decimal");

double  d1 = 1.1234; //No literal = double | 15 a 17 digitos (após o ponto decimal)
float   f1 = 1.1234f; // literal F = float | 6 a 9 digitos (após o ponto decimal)
decimal d2 = 1.1234m; // literal M = decimal |28 a 29 digitos (após o ponto decimal)

Console.WriteLine(d1);
Console.WriteLine(f1);
Console.WriteLine(d2);

//Giving max range values for rach

Console.WriteLine("Atribuindo valores a double, float e decimal com valor maximo");

double d3 = 1.12345678910111213; //No literal = double | 15 a 17 digitos (após o ponto decimal)
float f2 = 1.123456789f; // literal F = float | 6 a 9 digitos (após o ponto decimal)
decimal d4 = 1.12345678910111213141516171819m; // literal M = decimal |28 a 29 digitos (após o ponto decimal)

Console.WriteLine(d3);
Console.WriteLine(f2);
Console.WriteLine(d4);

//Comparing precision between float, double and decimal

Console.WriteLine("Comparando a precisão");


float f = 1f / 3f;
double d = 1d / 3d;
decimal d5 = 1m / 3m;

Console.WriteLine(f);
Console.WriteLine(d);
Console.WriteLine(d5);