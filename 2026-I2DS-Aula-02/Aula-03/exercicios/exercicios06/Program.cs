internal class Program
{
    private static void Main(string[] args)
    {
        /* 
            Criar um programa que apresente a tabuada de um número informado pelo usuário.
        */
        string continuar = "s";


        while(continuar.ToLower() == "s")
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            MostrarTabuada(numero);
            Console.WriteLine();

            Console.Write("Deseja continuar? (s/n): ");
            continuar = Console.ReadLine();
        }
        Console.WriteLine("Programa encerrado.");
    }


    static void MostrarTabuada(int numero)
    {
        Console.WriteLine();
        Console.WriteLine($"Tabuada do {numero}");

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
