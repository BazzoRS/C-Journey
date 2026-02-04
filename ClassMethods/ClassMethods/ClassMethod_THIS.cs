

















//public class Cliente
//{

//    public string? Nome;
//    public int Idade;
//    public Cliente(string? Nome, int Idade)
//    {

//        this.Nome = Nome;
//        this.Idade = Idade;



//    }


//}

Teste t1 = new Teste();


t1.num1 = 10;
t1.num2 = 20;
t1.Exibir();

Teste t2 = new Teste();

t2.num1 = 88;
t2.num2 = 99;
t2.Exibir();

public class Teste
{
    public int num1;
    public int num2;

    public void PassarParametro(Teste t) {


        Console.WriteLine($"\nThis = {this}");
        Console.WriteLine($"\nNum1 = {t.num1}");
        Console.WriteLine($"\nNum2 = {t.num2}");
        
    
    }

    public void Exibir()
    {

        PassarParametro(this);

    }

}