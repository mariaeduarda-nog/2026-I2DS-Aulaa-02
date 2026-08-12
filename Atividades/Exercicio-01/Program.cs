internal class Program
{
    public class Frutas
    {
        public string? Nome {get; set;}
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

        // 1 - Iniciar um nova lista
        List<Frutas> listaFrutas = new List<Frutas>();

        Frutas fruta1 = new Frutas{ 
            Nome = "Maca"};
        Frutas fruta2 = new Frutas{ 
            Nome = "Manga"};
        Frutas fruta3 = new Frutas{ 
            Nome = "limao"};
        Frutas fruta4 = new Frutas{ 
            Nome = "Moarango"};
        Frutas fruta5 = new Frutas{ 
            Nome = "Abacaxi"};
                

        // 2 - Incluir elementos em uma lista
        listaFrutas.Add(fruta1);
        listaFrutas.Add(fruta2);
        listaFrutas.Add(fruta3);
        listaFrutas.Add(fruta4);
        listaFrutas.Add(fruta5);

        // 3 - Percorrer todos os elementos de uma lista     
        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.Nome}");
        }

        // 4 - Alterar um elemento da lista
        listaFrutas[2].Nome = "Melancia";
        
        Console.WriteLine();
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }

        // 7 - quantidade de elementos da lista
        Console.WriteLine($"Quantidade de elementos na lista{listaFrutas.Count()}");
    
    }
}