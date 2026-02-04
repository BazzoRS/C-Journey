//Escape Sequence	Represents
// \a	Bell (alert)
// \b	Backspace
// \f	Form feed
// \n	New line
// \r	Carriage return
// \t	Horizontal tab
// \v	Vertical tab
// \'	Single quotation mark
// \"	Double quotation mark
// \\	Backslash
// \?	Literal question mark
// \ ooo	ASCII character in octal notation
// \x hh	ASCII character in hexadecimal notation
// \x hhhh	Unicode character in hexadecimal notation if this escape sequence is used in a wide-character constant or a Unicode string literal.

//For example, WCHAR f = L'\x4e00' or WCHAR b[] = L"The Chinese character for one is \x4e00".Escape Sequence	Represents
// \a	Bell (alert)
// \b	Backspace
// \f	Form feed
// \n	New line
// \r	Carriage return
// \t	Horizontal tab
// \v	Vertical tab
// \'	Single quotation mark
// \"	Double quotation mark
// \\	Backslash
// \?	Literal question mark
// \ ooo	ASCII character in octal notation
// \x hh	ASCII character in hexadecimal notation
// \x hhhh	Unicode character in hexadecimal notation if this escape sequence is used in a wide-character constant or a Unicode string literal.

//For example, WCHAR f = L'\x4e00' or WCHAR b[] = L"The Chinese character for one is \x4e00".

string local_Path = "c:\\dados\\ficheiro"; //trogle double backslash will vanish the issue on the single backslash
string phase = "He said \"It wasan't me!\""; // Same for double quotation, one slash will handle as mentioned on the above section
string pizza = "\nMussarela\nPizza\nWith\nBacon"; //New vertical line

Console.WriteLine(local_Path);
Console.WriteLine(phase);
Console.WriteLine(pizza);