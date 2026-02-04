Console.WriteLine("Enter the class member name");
var name = Console.ReadLine();
Console.WriteLine("Enter the class member rate");
int rate = Convert.ToInt32(Console.ReadLine());

if (rate < 5)

{

    Console.WriteLine("Failed");

}

else if (rate >= 5 && rate <= 6)

{

    Console.WriteLine("Exam");

}

else if (rate >= 6 && rate <= 9)

{

    Console.WriteLine("Approved");

}

else if (rate > 9)

{

    Console.WriteLine("Highly Approved");

}