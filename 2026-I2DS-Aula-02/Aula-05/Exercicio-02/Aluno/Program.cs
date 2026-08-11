internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro aluno
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Matheus";
        aluno1.Email =  "Matheuscastilho003@gmail.com";
        aluno1.Nascimento = "03/09/2009";
        aluno1.RM = 4477;

        // Primeiro aluno
        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Julio";
        aluno2.Email =  "Julionagaita@gmail.com";
        aluno2.Nascimento = "02/03/2010";
        aluno2.RM = 9988;

     // Primeiro aluno
        Aluno aluno3 = new Aluno();
        aluno3.Nome = "Alice";
        aluno3.Email =  "Lice@gmail.com";
        aluno3.Nascimento = "09/09/2000";
        aluno3.RM = 5234;

        // Exibindo os Livro na Tela
        Console.WriteLine("==== LIVROS ====");
        Console.WriteLine($"\nAluno 01: {aluno1.Nome} | Email: {aluno1.Email}. | Nascimento: {aluno1.Nascimento} | RM: {aluno1.RM}");
        Console.WriteLine($"Aluno 02: {aluno2.Nome} | Email: {aluno2.Email} | Nascimento: {aluno2.Nascimento} | RM: {aluno2.RM}");
        Console.WriteLine($"Aluno 03: {aluno3.Nome} | Email: {aluno3.Email} | Nascimento: {aluno3.Nascimento} | RM: {aluno3.RM}");
    }

    public class Aluno
    {
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Nascimento {get; set;}
        public int RM {get; set;}
    }
}