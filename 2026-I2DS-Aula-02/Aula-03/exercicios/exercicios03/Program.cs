internal class Program
{
    private static void Main(string[] args)
    {
        double nota1;
        double nota2;
        double nota3;
        double media;
        string nome;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Acesso Permitido! ");
        
        Console.WriteLine("Agora, digite sua Nota 1: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Agora, digite sua Nota 2: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Agora, digite sua Nota 3: ");
        nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Calculando... ");

        media = (nota1 + nota2 + nota3) / 3;


        if (media >= 7)
        {
            Console.WriteLine(nome + ", você foi Aprovado, Média: " + media);
        }
        else
        {
            Console.WriteLine(nome + ", você foi Reprovado, Média: " + media);
        }
    }
}