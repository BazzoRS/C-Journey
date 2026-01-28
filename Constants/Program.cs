const int ANO = 1999;
const int MES = 12, DIAS_ANO = 365;
const float DIAS_POR_MES =  (float)DIAS_ANO / (float) MES ;

Console.WriteLine($"A Média de dias por mes é igual: {DIAS_POR_MES}");


// Calculating the perimiter of a circle

double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("Informe o raio do Circulo");
raio = Convert.ToDouble(Console.ReadLine());
perimetro = 2 * PI * raio;
area = PI * raio * raio;
Console.WriteLine($"O perimetro do circulo informado é de: {perimetro}");
Console.WriteLine($"A area do circulo informado é de: {area}");