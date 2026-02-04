//Text concatenation using "+"

string name = "Maria";
string sname = "Rosana Bazzo";
string space = " ";
int old = 25;

Console.WriteLine(name + space + sname + space + old); // Concatenating all values using +

// String interpolatio: use $ before quotes " " and variables always inside {.......}

Console.WriteLine($"{name} {sname} {old}");

// Place holder for concatenation - Use {0..1..2..} to assign the standard order for the future assigning variables

Console.WriteLine("{0} {1} {2}", name, sname, old);