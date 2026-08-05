    {
    int num1;
        int num2;
        Console.Write("Digite o Primeiro Número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        string operacao;
        
        Console.Write("Selecione uma Operação: ");
        operacao = Console.ReadLine();

        switch (operacao)
        {
            case "1": 
                Console.WriteLine(num1 + num2);
                break;
            case "2": 
                Console.WriteLine(num1 - num2);
                break;
            case "3": 
                Console.WriteLine(num1 * num2);
                break;
            case "4": 
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Operador informado não é válido.");
                break;
        }
    }

