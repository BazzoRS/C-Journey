//Pre - definition types
sbyte  primeirosbyte; //-128 a 127 - inteiro de 8 bits com sinal
byte   primeirobyte; //0 a 255 - Inteiro de 8 bits sem sinal
short  primeiroshort; //-32.768 a 32.767 - Inteiro de 16 bits com sinal
ushort primeiroushort; // 0 a 65.535 - Inteiro de 16 bits sem sinal
int    primeiroint; //-2.147.483.648 a 2.147.483.647 - Inteiro assinado de 32 bits
uint   primeirouint; //0 a 4.294.967.295 - Inteiro assinado de 32 bits sem sinal
long   primeirolong; // -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 - Inteiro assinado de 64 bits
ulong  primeiroulong; // 0 a 18.446.774.073.709.551.615 Inteiro de 64 bits sem sinal
nint   primeironint; // Depende da plataforma - Inteiro com sinal de 32 ou 64 bits
nuint  primeironuint; // Depende da plataforma - Inteiro sem sinal de 32 bits ouy 64bits

//Assigning value for each variable based on the characteristics

primeirosbyte = -128;
primeirobyte = 200;
primeiroshort = -30000;
primeiroushort = 60000;
primeiroint = 12;
primeirouint = 4000000;
primeirolong = -9000000;
primeiroulong = 8000000000;
primeironint = 12;
primeironuint = 12;

//Writing the results in console

Console.WriteLine(primeirosbyte);
Console.WriteLine(primeirobyte);
Console.WriteLine(primeiroshort);
Console.WriteLine(primeiroushort);
Console.WriteLine(primeiroint);
Console.WriteLine(primeirouint);
Console.WriteLine(primeirolong);
Console.WriteLine(primeiroulong);
Console.WriteLine(primeironint);
Console.WriteLine(primeironuint);

