    Console.WriteLine("Digite um numero!\t");
    var num = Convert.ToInt32(Console.ReadLine());

    for (; num <= 10; num++)
    {
    if (num == 2) {

        Console.WriteLine($"\nEstou retirando esse numero da fila: {num} e parando o processamento\n");
        continue; // Back for the for condition

    }

     Console.WriteLine(num);
     

    }
   

