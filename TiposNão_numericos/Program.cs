Console.WriteLine("Atribuindo valores bool e char");

int var1 = 1, var2 = 2;

Console.WriteLine(var1 == var2); //False
Console.WriteLine(var1 > var2); //false
Console.WriteLine(var1 < var2); //true

char var3 = 'A'; // Char always receive unicode values 'A', 'B'... Never 'ABC'
char var4 = '\u0041'; // Unicodes also has primitive values, check on site https://symbl.cc/pt/unicode-table/

Console.WriteLine("Exibindo diferença de declarações");

Console.WriteLine(var3);
Console.WriteLine(var4);


