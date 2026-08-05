internal class Program
{
    private static void Main(string[] args)
    {

     /*
     classe -> e a abstracao de um objeto do mundo real para o mundo computacional.
     objeto -> e a intancia de uma classe.
     */
      // Instanciar um objeto do tipo aluno 
      Aluno aluno01 = new Aluno();
      Aluno aluno02 = new Aluno();

      aluno01.Nome = "Pedro Henrique";
      aluno01.RM = 2444;
      aluno01.DataNascimento = new DateOnly(2008,03,30);

      aluno02.Nome = "Maria Eduarda";
      aluno02.RM = 1234;
      aluno02.DataNascimento = new DateOnly(2009,08,14);

      //Executar metodos
      aluno01.ApresentarSE();
      aluno02.ApresentarSE();
    }

      public class Aluno  // Declaracao de uma classe
    {
        // Atributos -> Caracteristicas
        public string Nome {get; set;}
        public int RM {get; set;}
        public DateOnly DataNascimento {get; set;}

        //Metodos -> Acoes ou Funcionalidades
        public void ApresentarSE()
        {
            Console.WriteLine($"Ola, meu nome e {Nome}, Meu RM e {RM} e nasci no dia {DataNascimento}");
    
        }
    }
}