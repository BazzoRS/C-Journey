/*
========================
TRUTH TABLE - AND (&&)
========================
C1 | C2 | Result
----------------
 V |  V |   V
 V |  F |   F
 F |  V |   F
 F |  F |   F
========================
*/


/*
========================
TRUTH TABLE - OR (||)
========================
C1 | C2 | Result
----------------
 V |  V |   V
 V |  F |   V
 F |  V |   V
 F |  F |   F
========================
*/

/*
========================
TRUTH TABLE - NOT (!)
========================
C1 | Result
------------
 V |   F
 F |   V
========================
*/


// && = "AND"
// || = "OR"
// ! = "NOT"

//using && Operator

bool c1 = 5 >= 7;
bool c2 = 6 != 7;

bool result = c1 && c2; // / c1 = F c2 = V, in && this is False
bool result1 = c1 || c2; // c1 = F c2 = V, in || this is TRUE
bool result2 = !(c1); //Its false, but ! make it true

Console.WriteLine($"Resultado de \"&&\" com base na tabela verdade é: {result}");
Console.WriteLine($"Resultado de \"||\" com base na tabela verdade é: {result1}");
Console.WriteLine($"Resultado de \"!\" com base na tabela verdade é: {result2}");