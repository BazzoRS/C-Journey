//Console.WriteLine("Provide the month name\t");
//var month = Console.ReadLine().ToLower();// Covert in lower capital!

//switch (month) 

//{

//    case "january":
//    case "march":
//    case "may":
//    case "july":
//    case "august":
//    case "october":
//    case "december":
//        Console.WriteLine("This month has 31 days"); //This rule will be applied to all months above
//        break;
//    case "february":
//        Console.WriteLine("This month has 28 days"); // Specific rule for FEB
//        break;
//    default:
//        Console.WriteLine("This month has 30 days"); // Specific rule for all unmatched months
//        break;

//}

int cargo = 0;
int funcao = 0;

Console.WriteLine("Você é gerente?(1) our programador(2) ?\t");
cargo = Convert.ToInt32(Console.ReadLine());

if(cargo == 2)
{

    Console.WriteLine("Você é Junior(1) ou Senior(2) \t?");
    funcao = Convert.ToInt32(Console.ReadLine());

}

switch(cargo)
{

    case 1:
        Console.WriteLine("\nBem vindo gerente!");
        break;

    case 2:
        Console.WriteLine("\nBem vindo programador!");
        switch (funcao)
        {

            case 1:
                Console.WriteLine("Você é Junior");
                break;
            case 2:
                Console.WriteLine("Você é senior");
                break;
            default:
                Console.WriteLine("Não encontramos sua função");
                break;        
        
        
        }
     break;
    default:
        Console.WriteLine("Não consegui te identificar!");
        break;
}