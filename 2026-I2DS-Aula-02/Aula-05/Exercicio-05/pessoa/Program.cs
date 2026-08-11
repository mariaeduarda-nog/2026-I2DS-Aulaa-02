using System.Dynamic;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "Cristiano de Paula";
        funcionario1.IdadeAtual = 32;
        funcionario1.Salario = 2750.00;
        funcionario1.Registro = 125;

        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Gustavo castello";
        funcionario2.IdadeAtual = 38;
        funcionario2.Salario = 3000.00;
        funcionario2.Registro = 244;

        Funcionario funcionario3 = new Funcionario();
        funcionario3.Nome = "Tung tung sahur";
        funcionario3.IdadeAtual = 67;
        funcionario3.Salario = 4120.00;
        funcionario3.Registro = 151;


        Console.WriteLine("=====Funcionarios====");

        Console.WriteLine("\nFuncionario 1");
        Console.WriteLine($"Nome: {funcionario1.Nome} ");
        Console.WriteLine($"Idade: {funcionario1.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario1.Registro}");
        Console.WriteLine($"Salario: {funcionario1.Salario}");

        Console.WriteLine("\nFuncionario 2");
        Console.WriteLine($"Nome: {funcionario2.Nome} ");
        Console.WriteLine($"Idade: {funcionario2.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario2.Registro}");
        Console.WriteLine($"Salario: {funcionario2.Salario}");

        Console.WriteLine("\nFuncionario 3");
        Console.WriteLine($"Nome: {funcionario3.Nome} ");
        Console.WriteLine($"Idade: {funcionario3.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario3.Registro}");
        Console.WriteLine($"Salario: {funcionario3.Salario}");



        funcionario1.envelhecer(13);
        funcionario1.envelhecer(22);
        funcionario1.envelhecer(17);

        Console.WriteLine($"{funcionario1.Nome}: {funcionario1.IdadeAtual} anos");
        Console.WriteLine($"{funcionario2.Nome}: {funcionario2.IdadeAtual} anos");
        Console.WriteLine($"{funcionario3.Nome}: {funcionario3.IdadeAtual} anos");


    }

    public class Pessoa
    {
        public string Nome {get; set;}
        public int IdadeAtual {get; set;}

        public void envelhecer(int anos)
        {
            IdadeAtual += anos;
        }
    }

    public class Funcionario : Pessoa
    {
        public double Salario {get; set;}
        public int Registro {get; set;}
    }
}
