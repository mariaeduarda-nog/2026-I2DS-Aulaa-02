internal class Program
{
    private static void Main(string[] args)
    {
        /* 
            Desenvolva um sistema bancário simples.

            O programa deve possuir:
            1 - Consultar saldo
            2 - Depositar
            3 - Sacar
            4 - Sair
            
            # Requisitos
            O sistema deve:
            - Controlar saldo;
            - Permitir depósitos;
            - Permitir saques;
            - Impedir saque maior que o saldo.
        */

        double saldo = 0;
        int opcao;

        do
        {
            Console.WriteLine("1 - Consultar Saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ConsultarSaldo(saldo);
                    break;
                case 2:
                    saldo = Depositar(saldo);
                    ConsultarSaldo(saldo);
                    break;
                case 3:
                    saldo = Sacar(saldo);
                    ConsultarSaldo(saldo);
                    break;
                case 4:
                    Console.WriteLine("Encerrando o Sistema...");
                    break;
                default:
                    Console.WriteLine("A opção selecionada não é válida");
                    break;
            }
            
        }while(opcao != 4);
    }

    public static void ConsultarSaldo(double saldo)
    {
        Console.WriteLine($"Saldo Atual: R$ {saldo:F2}");
    }

    public static double Depositar(double saldo)
    {
        double valor;
        Console.Write("Valor do Depósito: ");
        valor = double.Parse(Console.ReadLine());
        return saldo +=valor;
    }

    public static double Sacar(double saldo)
    {
        double valor;
        Console.Write("Valor do Saque: ");
        valor = double.Parse(Console.ReadLine());
        if (valor <= saldo)
        {
            return saldo -= valor;
          }
        else
        {
            Console.WriteLine("Saque não realizado. Saldo insuficiente.");
            return saldo;
        }
    }
}