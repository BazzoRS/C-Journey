//1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
//Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.

var nome = "Paulo";
int idade = 17;
var nota = 7.5;

Console.WriteLine($"Aluno {nome} tem {idade} e nota {nota}");
Console.WriteLine($"\nAluno {nome}\ntem {idade}\ne nota {nota}");

//5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
//a concatenação e também a interpolação de string


Console.WriteLine("Digite uma letra e pressione enter");

var a = Console.ReadLine();
var b = Console.ReadLine();
var c = Console.ReadLine();

Console.WriteLine($"Ordem reversa é: {c} {b} {a}");


