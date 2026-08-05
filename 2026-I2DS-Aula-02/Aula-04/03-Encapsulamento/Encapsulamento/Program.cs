internal class Program
{
    private static void Main(string[] args)
    {
        /* Encapsulamento -> visa "proteger" as propriedades da classe */
    
        Pessoa p1 = new Pessoa("Asdrubal","(14)99966-8822","asdrubal@gmail.com");

        p1.MostrarContato();

        p1.AlterarCelular("(16) 98858-7878");
        p1.MostrarContato();

    }
    public class Pessoa
    {
        // Modificador de acesso privado -> as atributos só podem ser acessado pela propria classe.

        private string Nome {get; set;} 
        private string Celular {get; set;}
        private string Email {get; set;}

        // Alterar o Método Construtor para receber os parametros na criação do Objeto.
        public Pessoa(string nome, string celular, string email)
        {
            this.Nome = nome;
            this.Celular = celular;
            this.Email = email;
        }
        public void MostrarContato()
        {
            Console.WriteLine($"Nome: {this.Nome} - Celular: {this.Celular} - E-mail: {this.Email}");
        }

        public void AlterarCelular(string celular)
        {
            this.Celular = celular;
        }

    }
}