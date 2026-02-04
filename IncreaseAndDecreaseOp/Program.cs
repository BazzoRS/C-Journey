//Post Increasing operation

int x = 10; // y = 10
int result = x++ + x; // Here x will turn to 11 just after the ++ so the last x is equal to 10 and the first is equal to 10
Console.WriteLine(result);

//Pre Increasing operation

int y = 10; // y = 10
int resulty = ++y + y; // now the y is globaly settle as 10+1, so the math is 11 + 11
Console.WriteLine(resulty);

//Post decreasing operation

int z = 10; // y = 10
int resultz = z-- + z; // Here x will turn to 11 just after the ++ so the last x is equal to 10 and the first is equal to 10
Console.WriteLine(resultz);

//Pre decreasing operation

int b = 10; // y = 10
int resultb = --b + b; // now the y is globaly settle as 10+1, so the math is 11 + 11
Console.WriteLine(resultb);