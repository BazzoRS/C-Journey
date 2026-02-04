// Labe example:

int counter = 0;

repeat:
Console.WriteLine($"Counter = {counter}");

counter++; // Label! Include 1 using post increasing

if (counter <= 10)
    goto repeat;

Console.WriteLine("End!");