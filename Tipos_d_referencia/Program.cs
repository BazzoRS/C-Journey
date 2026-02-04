Console.WriteLine("Demonstrações de string, object and dynamics");


// String = Free text | Object = Transformation type (the var type will follow the structure of the value) | 
string var1 = "Valor vazio para demonstração";
object var2 = 'A'; //Dinamico transformando-se em char (unicode)
object var3 = 123.4d; //Dinamico transformando-se em double
object var4 = 1f / 3f; //Dinamico transformando-se em float
object var5 = 1m / 3m; //Dinamico transformando-se em decimal


Console.WriteLine(var1);
Console.WriteLine(var2);
Console.WriteLine(var3);
Console.WriteLine(var4);
Console.WriteLine(var5);