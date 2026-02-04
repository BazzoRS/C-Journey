//Converting numbers to string using method toString

int valueInt = 123;
double valueDouble = 12.45;
decimal valueDecimal = 12.34239m;

string s1 = valueInt.ToString(); // No issue caused once we're converting the type to string
string s2 = valueDouble.ToString();
string s3 = valueDecimal.ToString();

Console.WriteLine($"{s1}\n{s2}\n{s3}"); // Using interpolation to garantee a good formating alojng with scape statment

// Another way to make the convertion


int var1 = 10;
double vard1 = 5.34;
bool varb1 = true;

Console.WriteLine(Convert.ToString(var1));
Console.WriteLine(Convert.ToString(vard1));
Console.WriteLine(Convert.ToString(varb1));


//Overflow exception simulation


int var2 = 10000;
Console.WriteLine(Convert.ToByte(var2)); // int has 4 byts and bytes has only 1, so overflow is excpected

