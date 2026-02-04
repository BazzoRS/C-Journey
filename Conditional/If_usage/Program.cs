Console.WriteLine("Special Client?(true/false)");
Boolean answer = Convert.ToBoolean(Console.ReadLine());

if (answer)

{

    Console.WriteLine("Offer Applied!");

}
else
{

    Console.WriteLine("Offer not applied!");

}

Console.WriteLine("Give \"X\" a number!");
int answerx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Give \"Y\" a number!");
int answery = Convert.ToInt32(Console.ReadLine());

if (answerx > answery)

{

    Console.WriteLine("X is greater than Y");

}
else
{

    Console.WriteLine("Y is greater than X");

}