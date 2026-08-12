internal class Program
{
    public class Aluno
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Matricula {get; set;}
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

        // 1 - Iniciar um nova lista
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno{ 
            Id = 1, Nome = "Zuleika",Matricula = "12345"};
        Aluno aluno2 = new Aluno{ 
            Id = 2, Nome = "Pafúncio",Matricula = "25256"};
        Aluno aluno3 = new Aluno{ 
            Id = 3, Nome = "Asdrúbal",Matricula = "85235"};

        // 2 - Incluir elementos em uma lista
        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2); 
        listaAlunos.Add(aluno3);

        // 3 - Percorrer todos os elementos de uma lista     
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.Matricula}");
        }

        // 4 - Alterar um elemento da lista
        listaAlunos[1].Matricula = "55555";
        listaAlunos[2].Nome = "Eleutério";
        
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 5 - Remover um elemento da lista por índice
        listaAlunos.RemoveAt(0);
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 6 - Remover um elemento da lista por objeto 
        listaAlunos.Remove(aluno3);
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 7 - quantidade de elementos da lista
        Console.WriteLine($"Quantidade de elementos na lista{listaAlunos.Count()}");

        // 8 - Remover todos os elementos da lista
        listaAlunos.Clear();
    }
}