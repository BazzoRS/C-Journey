//sbyte   short, int, long, float, double, decimal, or nint
//byte	  short, ushort, int, uint, long, ulong, float, double, decimal, nint, or nuint
//short	  int, long, float, double, decimal, or nint
//ushort  int, uint, long, ulong, float, double, decimal, nint, or nuint
//int	  long, float, double, decimal, or nint
//uint	  long, ulong, float, double, decimal, or nuint
//long	  float, double, or decimal
//ulong	  float, double, or decimal
//float	  double
//nint	  long, float, double, or decimal
//nuint	  ulong, float, double, or decimal


//Implicit type convertion

int var1 = 100;
double var2 = var1;

Console.WriteLine(var2); // int (4 bytes fit inside double 8 bits, but the oposite is not possible)

int var3 = 2382781;
long var4 = var3; //int to long
float var5 = var3; //int to float
double var6 = var3; //int to double
decimal var7 = var3; //int to decimal

Console.WriteLine(var3);
Console.WriteLine(var4);
Console.WriteLine(var5);
Console.WriteLine(var6);
Console.WriteLine(var7);

//Explicit type convertion

double var8 = 12.756;  //8 bytes
int var9 = (int)var8;   //4 bytes - after the explicit convertion, the number is reduced to the standard form, no roudings 

Console.WriteLine(var9);

int var10 = 10;
int var11 = 4;

float var12 = (float) var10 / var11; //also use the explicit convertion when you want to format the resulting value differently of his type (int)

Console.WriteLine(var12);