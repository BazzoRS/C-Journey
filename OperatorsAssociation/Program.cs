/*
============================================
C# Operator Precedence & Associativity
(based on Microsoft C# operator reference)
============================================

Precedence (highest to lowest)    | Operators                            | Associativity
----------------------------------------------------------------------------------------
Primary                          | x.y  f(x)  a[i]  x++  x--           | Left → Right
                                 | new  typeof  checked  unchecked     |
----------------------------------------------------------------------------------------
Unary                           | ++x  --x  +x  -x  !x  ~x             | Right → Left
----------------------------------------------------------------------------------------
Multiplicative                 | *  /  %                              | Left → Right
----------------------------------------------------------------------------------------
Additive                       | +  -                                 | Left → Right
----------------------------------------------------------------------------------------
Relational                     | <  <=  >  >=                         | Left → Right
----------------------------------------------------------------------------------------
Equality                      | ==  !=                                | Left → Right
----------------------------------------------------------------------------------------
Logical AND                  | &&                                    | Left → Right
----------------------------------------------------------------------------------------
Logical OR                   | ||                                    | Left → Right
----------------------------------------------------------------------------------------
Assignment                  | =  +=  -=  *=  /=  %=                  | Right → Left
----------------------------------------------------------------------------------------

Notes:
- Postfix increment/decrement (x++, x--) has the highest precedence. :contentReference[oaicite:2]{index=2}
- Unary operators (++x, --x, +, -, !, ~) bind before arithmetic. :contentReference[oaicite:3]{index=3}
- Arithmetic * / % are evaluated before + -. :contentReference[oaicite:4]{index=4}
- Relational (<, >, <=, >=) and equality (==, !=) group left to right. :contentReference[oaicite:5]{index=5}
- Logical AND (&&) has higher precedence than Logical OR (||). :contentReference[oaicite:6]{index=6}
- Assignment operators are right-associative. :contentReference[oaicite:7]{index=7}
*/

int x = 10 - 2 * 3; // * will be performed first -> 4
int y = (10 - 2) * 3;  // - will be performed first -> 24

Console.WriteLine($"Resultado aritimetico = {x}");
Console.WriteLine($"Resultado aritimetico considerando () = {y}");

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;


Console.WriteLine(b);

bool C = !(9 != 8) && (5 >= 7 || 8 >= 6); 

Console.WriteLine(C);


//-------------------------------------------------------


int d = 5, e = 6, f = 4;
int result = --d * e - ++f;

Console.WriteLine($"Resultado da associação é de {result}");