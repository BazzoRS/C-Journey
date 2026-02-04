const string APLUS = "A+";
const string A = "A";
const string B = "B";
const string C = "C";
const string E = "E";
const string F = "F";


Console.WriteLine("Digite a nota do aluno"); 
var nota = Convert.ToInt32(Console.ReadLine());

while (true)
{


    switch (nota) 
    
    {

        case 10:
            Console.WriteLine($"Sua nota é: {APLUS}");            
            break;
        case 9:
            Console.WriteLine($"Sua nota é: {A}");
            break;
        case 8:
            Console.WriteLine($"Sua nota é: {B}");
            break;
        case 7:
            Console.WriteLine($"Sua nota é: {B}");
            break;
        case 6:
            Console.WriteLine($"Sua nota é: {C}");
            break;
        case 5:
            Console.WriteLine($"Sua nota é: {E}");
            break;
        default:

            if (nota <= 4)
            {

                Console.WriteLine($"Sua nota é: {F}");

            }

            else
            {

                Console.WriteLine("Numero invalido, por favor digite de 0 a 10!");

            }

                break;
            
    }

    if ( true ) {

        break;
    
    }


}