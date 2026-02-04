// Declaring date variable based on the runtime hour

DateTime datePresent = DateTime.Now;

Console.WriteLine("Horas atuais " +  datePresent);

// Assigning a existing date

DateTime datahoje = new DateTime(22, 09, 06); // Defining date without hours
Console.WriteLine("Data sem horas " + datahoje);

// Assigning a existing date along the hours

DateTime datahorahoje = new DateTime(22, 09, 06, 21, 10, 30); // Defining date without hours
Console.WriteLine("Data sem horas " + datahorahoje);
//------------------------------------------------------------------------------------------
//
//
//
//
//
//------------------------------------------------------------------------------------------


// Extracting Data from date var
Console.WriteLine("Extracting data from present date:");
Console.WriteLine("");
Console.WriteLine(datePresent.Year); // Extrai somente o ano
Console.WriteLine(datePresent.Month); // Extrai somente o Mês
Console.WriteLine(datePresent.Day); // Somente o dia
Console.WriteLine(datePresent.Minute); // Minutos
Console.WriteLine(datePresent.Second); // Segundos
Console.WriteLine(datePresent.Millisecond); //Milisegundo
Console.WriteLine("");


// Increasing value to present date: 
Console.WriteLine("Increasing data to current date:");
Console.WriteLine("");
Console.WriteLine(datePresent.AddDays(30)); //Adiciona 30 dias a data na variante
Console.WriteLine(datePresent.AddDays(1)); // Adiciona 1 dia na variavel
Console.WriteLine(datePresent.AddDays(2)); // Adicional 2 dias na variavel
Console.WriteLine(datePresent.AddDays(5)); // Adiciona 5 dias na variavel
Console.WriteLine("");

// Catching value from week and year: 
Console.WriteLine("Catching value from week and year");
Console.WriteLine("");
Console.WriteLine(datePresent.DayOfWeek); //Dia da semana
Console.WriteLine(datePresent.DayOfYear); //Dia do ano (1 entre 365) 
Console.WriteLine("");

// Converting to long and short
Console.WriteLine("Converting to long and short");
Console.WriteLine("");
Console.WriteLine(datePresent.ToShortDateString()); //Dia, mês, anos
Console.WriteLine(datePresent.ToShortTimeString()); //Hora, Minuto
Console.WriteLine(datePresent.ToLongDateString()); // Dia da semana, dia do mês, mes e ano
Console.WriteLine(datePresent.ToLongTimeString()); // Hora, minuto, segundo
