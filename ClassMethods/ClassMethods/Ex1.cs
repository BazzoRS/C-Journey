Carro carro1 = new Carro();
carro1.modelo = "Sedan";
carro1.montadora = "Chevrolet";
carro1.marca = "Onix";
carro1.ano = 2016;
carro1.potencia = 110;

Console.WriteLine($"{carro1.modelo}\n{carro1.montadora}\n{carro1.marca}\n{carro1.ano}\n{carro1.potencia}\n" );
carro1.Acelerar(carro1);

Carro carro2 = new Carro();
carro2.modelo = "SUV";
carro2.montadora = "Ford";
carro2.marca = "EcoSport";
carro2.ano = 2018;
carro2.potencia = 120;

Console.WriteLine($"{carro2.modelo}\n{carro2.montadora}\n{carro2.marca}\n{carro2.ano}\n{carro2.potencia}\n");
carro1.Acelerar(carro2);

class Carro {

    public Carro(string modelo, string montadora, string marca, int ano, int potencia) { 
    
    
    
    
    }  

 


    public void Acelerar() {

        Console.WriteLine($"Acelerando meu {marca}\n");
    
    }


    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

}