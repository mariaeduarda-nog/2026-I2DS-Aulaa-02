internal class Program
{
    static void Main()
    {
        /* 
            Crie um programa que armazene as notas dos alunos utilizando um vetor.
            
            # Requisitos
            O programa deve informar:
            - Maior nota;
            - Menor nota;
            - Média da turma;
            - Quantidade de alunos aprovados.

            # Regra: Aluno aprovado: Nota maior ou igual a 7
        */
        
        Console.Write("Quantidade de alunos: ");
        int quantidade = int.Parse(Console.ReadLine());

        double[] notas = new double[quantidade];
        LerNotas(notas);

        double media = CalcularMedia(notas);
        double maior = EncontrarMaior(notas);
        double menor = EncontrarMenor(notas);

        int aprovados = ContarAprovados(notas);

        Console.WriteLine();
        Console.WriteLine($"Média da turma: {media}");
        Console.WriteLine($"Maior nota: {maior}");
        Console.WriteLine($"Menor nota: {menor}");
        Console.WriteLine($"Quantidade aprovados: {aprovados}");
    }
    static void LerNotas(double[] notas)
    {
        for(int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Nota do aluno {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }
    }
    static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        for(int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }
        return soma / notas.Length;
    }
    static double EncontrarMaior(double[] notas)
    {
        double maior = notas[0];
        for(int i = 1; i < notas.Length; i++)
        {
            if(notas[i] > maior)
            {
                maior = notas[i];
            }
        }
        return maior;
    }
    static double EncontrarMenor(double[] notas)
    {
        double menor = notas[0];
        for(int i = 1; i < notas.Length; i++)
        {
            if(notas[i] < menor)
            {
                menor = notas[i];
            }
        }
        return menor;
    }
    static int ContarAprovados(double[] notas)
    {
        int quantidade = 0;

        for(int i = 0; i < notas.Length; i++)
        {
            if(notas[i] >= 7)
            {
                quantidade++;
            }
        }
        return quantidade;
    }
}
