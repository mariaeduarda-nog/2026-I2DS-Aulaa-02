internal class Program
{
    private static void Main(string[] args)
    {
        /* 
            Desenvolva um programa utilizando vetores para armazenar 5 produtos.

            Utilize:
            string[] produtos;
            double[] precos;

            # Requisitos

            O sistema deve permitir:

            1. Cadastrar produtos;
            2. Cadastrar preços;
            3. Listar produtos cadastrados;
            4. Pesquisar um produto pelo nome.
        */
        string[] produtos = new string[5];
        double[] precos = new double[5];


        CadastrarProdutos(produtos,precos);

        ListarProdutos(produtos,precos);

        Console.WriteLine();

        Console.Write("Pesquisar produto: ");

        string pesquisa = Console.ReadLine();


        PesquisarProduto(produtos,precos,pesquisa);
    }

    static void CadastrarProdutos(string[] produtos,double[] precos)
    {
        for(int i = 0; i < produtos.Length; i++)
        {
            Console.Write($"Produto {i + 1}: " );
            produtos[i] = Console.ReadLine();
            
            Console.Write("Preço: ");
            precos[i] = double.Parse(Console.ReadLine());
        }
    }


    static void ListarProdutos(string[] produtos, double[] precos)
    {
        Console.WriteLine();

        Console.WriteLine("Produtos cadastrados: ");

        for(int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine(
                $"{produtos[i]} - R$ {precos[i]}"
            );
        }
    }


    static void PesquisarProduto(string[] produtos,double[] precos,string pesquisa)
    {
        bool encontrado = false;
        for(int i = 0; i < produtos.Length; i++)
        {
            if(produtos[i].ToLower() == pesquisa.ToLower())
            {
                Console.WriteLine();
                Console.WriteLine($"Produto encontrado: {produtos[i]}");
                Console.WriteLine($"Preço: {precos[i]}");
                encontrado = true;
            }
        }

        if(!encontrado)
        {
            Console.WriteLine(
                "Produto não encontrado."
            );
        }
    }
}

