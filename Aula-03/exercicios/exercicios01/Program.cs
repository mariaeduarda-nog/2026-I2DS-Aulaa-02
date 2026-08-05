internal class Program
{
    private static void Main(string[] args)
    {

/* EXERCICIO 1
Criar um programa capaz de converter temperaturas entre diferentes unidades.

O exercício tem como objetivo trabalhar:

- Variáveis;
- Entrada de dados;
- Operações matemáticas;
- Métodos.                   
*/ 

//precisamos configurar uma variavel para CELSIUS

int celsius;
Console.Write("digite a temperatura em graus celsius: ");
celsius = int.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine("A temperatura em fahrenheit e: " + fahrenheit);
    }
}

    