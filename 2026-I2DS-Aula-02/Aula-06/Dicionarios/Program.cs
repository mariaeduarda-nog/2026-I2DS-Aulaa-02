internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");
        // Sintaxe Dictonary<chave, valor>
        //                  <key, value>
        
        // 1 - Criar um dicionário vazio
        Dictionary<string, string> dicionario = new Dictionary<string, string>();
        
        // 2 - Adicionar elementos no dicionario
        dicionario.Add("Casa","Construção destinada à moradia.");
        dicionario.Add("Livro","Conjunto de páginas encadernadas contendo textos, imagens ou informações.");
        dicionario.Add("Amizade","Relação de afeto, confiança e companheirismo entre pessoas.");
        dicionario.Add("Escola","Instituição destinada ao ensino e à educação de crianças, jovens ou adultos.");

        // 3 - Percorrer todos os elemetos de um dicionario
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 4 - Alterar um elemento do dicionario
        dicionario["Casa"] = "Construção destinada à moradia definitiva ou temporária.";
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 5 - Verificar se uma chave (key) existe dentro do dicionário
        string termo;
        bool chaveExiste = dicionario.TryGetValue("Amizade", out termo);
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"A palavra foi encontrada: {termo}");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada no dicionário");
        }

        // 6 - Excluir um elemento do dicionario -> Somente por Chave(Key)
        dicionario.Remove("Casa");
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 7 - Ordenar um Dicionario por chave
        dicionario.OrderBy(i => i.Key);
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }



    }
}