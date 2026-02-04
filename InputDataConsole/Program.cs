//Console readline being included on a variable type string

//ASCII reference: https://www.w3schools.com/charsets/ref_html_ascii.asp

Console.WriteLine("\nProvide your name");

string name = Console.ReadLine();

Console.WriteLine($"\nYour name is: {name}");

Console.ReadKey();

Console.WriteLine("\nProvide your old");

int old = Convert.ToInt32(Console.ReadLine()); //Converting string from readline to INT32

Console.WriteLine($"\nYour old is: {old}");

Console.WriteLine("\nProvide your size");

int size = Convert.ToInt32(Console.Read()); //Converting string from readline to INT32 but read statment will brin ASCII code

Console.WriteLine($"\nYour old is: {size}"); 