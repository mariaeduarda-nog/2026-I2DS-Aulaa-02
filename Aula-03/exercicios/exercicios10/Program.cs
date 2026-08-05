internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Desenvolva um sistema para controlar livros.

            Utilize:
            string[] livros;
            bool[] disponivel;

            # Menu
            O sistema deve possuir:
            1 - Cadastrar livro
            2 - Listar livros
            3 - Pesquisar livro
            4 - Emprestar livro
            5 - Devolver livro
            6 - Sair
            
            # Requisitos
            O sistema deve:
            - Permitir cadastro de livros;
            - Listar livros cadastrados;
            - Pesquisar livros;
            - Controlar disponibilidade;
            - Permitir empréstimo;
            - Permitir devolução.
         */

        string[] livros = new string[5];
        bool[] disponivel = new bool[5];
        int opcao;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar livro");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("3 - Pesquisar livro");
            Console.WriteLine("4 - Emprestar livro");
            Console.WriteLine("5 - Devolver livro" );
            Console.WriteLine("6 - Sair");

            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Cadastrar(livros,disponivel);
                    break;
                case 2:
                    Listar(livros,disponivel);
                    break;
                    Pesquisar(livros,disponivel);
                    break;
                case 4:
                    Emprestar(disponivel);
                    break;
                case 5:
                    Devolver(disponivel);
                    break;
            }
        }while(opcao != 6);
    }


    static void Cadastrar(string[] livros, bool[] disponivel)
    {
        for(int i = 0; i < livros.Length; i++)
        {
            if(livros[i] == null)
            {
                Console.Write("Nome do livro: " );
                livros[i] = Console.ReadLine();
                disponivel[i] = true;

                Console.WriteLine("Livro cadastrado.");
                break;
            }
        }
    }


    static void Listar(string[] livros,bool[] disponivel)
    {
        for(int i = 0; i < livros.Length; i++)
        {
            if(livros[i] != null)
            {
                Console.WriteLine($"{livros[i]} - {(disponivel[i] ? "Disponível" : "Emprestado")}");
            }
        }
    }


    static void Pesquisar(string[] livros,bool[] disponivel)
    {
        Console.Write("Pesquisar: ");
        string pesquisa = Console.ReadLine();

        for(int i = 0; i < livros.Length; i++)
        {
            if(livros[i] == pesquisa)
            {
                Console.WriteLine("Livro encontrado.");
                return;
            }
        }
        Console.WriteLine("Livro não encontrado.");
    }

    static void Emprestar(bool[] disponivel)
    {
        Console.Write("Número do livro: ");

        int posicao = int.Parse(Console.ReadLine());
        disponivel[posicao] = false;
    }

    static void Devolver(bool[] disponivel)
    {
        Console.Write("Número do livro: ");

        int posicao =int.Parse(Console.ReadLine());
        disponivel[posicao] = true;
    }
}
