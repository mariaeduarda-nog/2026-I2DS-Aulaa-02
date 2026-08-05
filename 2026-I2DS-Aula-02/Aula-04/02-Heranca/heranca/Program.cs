using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         Herança: uma Subclasse (Classe Filha) recebe os atributos e metodos da Super Classe (Classe Mãe)
        */

        Animal animal01 = new Animal();
        Cachorro dog01 = new Cachorro();

        animal01.Nome = "Ferdinando";
        animal01.Idade = 2;

        Console.WriteLine($"Nome do Animal: {animal01.Nome} - Idade {animal01.Idade}");

        dog01.Nome = "Snoop";
        dog01.Idade = 5;
        dog01.Raca = "Vira-Lata";
        dog01.Latir();

        Console.WriteLine($"Nome: {dog01.Nome} | Idade: {dog01.Idade} | Raça: {dog01.Raca}");



    }

    // Super Classe Animal (Classe Mãe)
    public class Animal
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
    }

    // Sub Classe Cachorro (Classe Filha)
    public class Cachorro : Animal
    {
        public string Raca {get; set;}
        public void Latir()
        {
            Console.WriteLine("Au Au");
        }
    }
}