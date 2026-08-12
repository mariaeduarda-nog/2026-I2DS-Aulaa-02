using System.Reflection.Metadata;

internal class Program
{
    public class Colaborador
    {
        public string? Nome {get;set;}
        public double Salario {get;set;}
        public DateOnly DataRegistro {get; set;} 
    }
    private static void Main(string[] args)
    {
        Colaborador colab1 = new Colaborador {
            Nome = "Ana", 
            Salario = 1750.00, 
            DataRegistro = new DateOnly(2026,01,10)
        };
        Colaborador colab2 = new Colaborador {
            Nome = "Joao", 
            Salario = 2250.00, 
            DataRegistro = new DateOnly(2025,02,10)
        };
        Colaborador colab3 = new Colaborador {
            Nome = "Pedro", 
            Salario = 6990.00, 
            DataRegistro = new DateOnly(2020,01,10)
        };
        Colaborador colab4 = new Colaborador {
            Nome = "Tiago", 
            Salario = 500.00, 
            DataRegistro = new DateOnly(2026,07,01)
        };
        Colaborador colab5 = new Colaborador {
            Nome = "José", 
            Salario = 17500.00, 
            DataRegistro = new DateOnly(2010,01,10)
        };

        // Criar um lista de colaboradores
        List<Colaborador> listaColab = new List<Colaborador>();
        listaColab.Add(colab1);
        listaColab.Add(colab2);
        listaColab.Add(colab3);
        listaColab.Add(colab4);
        listaColab.Add(colab5);

        Console.WriteLine("\n=== LISTA DE COLABORADORES ===");
        ImprimirLista(listaColab);

        Console.WriteLine("\n=== LISTA ORDENADA POR NOME ===");
        var listaOrdenadaNome = listaColab.OrderBy(c => c.Nome).ToList();
        ImprimirLista(listaOrdenadaNome);

        Console.WriteLine("\n=== LISTA ORDENADA POR NOME DECRESCENTE ===");
        var listaNomeInversa = listaColab.OrderByDescending(item => item.Nome).ToList();
        ImprimirLista(listaNomeInversa);

        Console.WriteLine("\n=== LISTA ORDENADA POR SALÁRIO ===");
        var listaSalario = listaColab.OrderBy(c => c.Salario).ToList();
        ImprimirLista(listaSalario);
        Console.WriteLine("\n=== LISTA DE SALÁRIOS MAIORES QUE R$ 2.000,00 ===");
        var listaSalarioAlto = listaColab
        .Where(colab => colab.Salario >= 2000)
        .Where(colab => colab.DataRegistro <= new DateOnly(2020,12,31))
        .OrderBy(colab => colab.Salario)
        .ToList();
        
        ImprimirLista(listaSalarioAlto);

        // foreach (var colab in listaSalarioAlto)
        // {
        //     if(colab.Salario >= 2000)
        //     {
        //         Console.WriteLine($"Nome: {colab.Nome} - Salário R$: {colab.Salario} - Data de Registo: {colab.DataRegistro}")
        //     }
        // }


        Console.WriteLine("\n=== COLABORADOR COM O MAIOR SALARIO ===");
        var colaboradorCaro = listaColab.MaxBy(colab => colab.Salario);
        Console.WriteLine();
        Console.WriteLine($"Nome: {colaboradorCaro.Nome} - Salário R$: {colaboradorCaro.Salario} - Data de Registo: {colaboradorCaro.DataRegistro}");
    
    
        Console.WriteLine("\n=== COLABORADOR COM O MENOR SALARIO ===");
        var colaboradorMenorS = listaColab.MinBy(colab => colab.Salario);
        Console.WriteLine();
        Console.WriteLine($"Nome: {colaboradorMenorS.Nome} - Salário R$: {colaboradorMenorS.Salario} - Data de Registo: {colaboradorMenorS.DataRegistro}");

    }


    public static void ImprimirLista(List<Colaborador> lista)
    {
        Console.WriteLine();
        foreach (var colab in lista)
        {
            Console.WriteLine($"Nome: {colab.Nome} - Salário R$: {colab.Salario:F2} - Data de Registro: {colab.DataRegistro}");
        }
    }
}