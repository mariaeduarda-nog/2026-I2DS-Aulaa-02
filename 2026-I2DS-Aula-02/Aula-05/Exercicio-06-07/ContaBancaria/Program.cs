internal class Program
{
    private static void Main(string[] args)
    {
        // Primeira Conta : ContaBancaria (Sem Limite)
        ContaBancaria contaSimples = new ContaBancaria(
            "Banco do Brasil",1234,100011,500.00);

        // Segunda Conta : ContaCorrente (Com Limite)
        ContaCorrente contaCorrente = new ContaCorrente(
            "Itaú", 2444,222333, 1500.00,3000.00);

        // Exibindo as contas
        Console.WriteLine("=== CONTAS CORRENTES ===");

        Console.WriteLine("\nConta 1");
        Console.WriteLine($"Banco: {contaSimples.Banco}");
        Console.WriteLine($"Agência: {contaSimples.Agencia}");
        Console.WriteLine($"Conta: {contaSimples.Conta}");
        Console.WriteLine($"Saldo: R$ {contaSimples.SaldoAtual:F2}");

        Console.WriteLine("\nConta 2");
        Console.WriteLine($"Banco: {contaCorrente.Banco}");
        Console.WriteLine($"Agência: {contaCorrente.Agencia}");
        Console.WriteLine($"Conta: {contaCorrente.Conta}");
        Console.WriteLine($"Saldo: R$ {contaCorrente.SaldoAtual:F2}");
        Console.WriteLine($"Limite: R$ {contaCorrente.Limite:F2}");

        // Realizando operações
        Console.WriteLine("\n=== OPERAÇÕES ===");

        Console.WriteLine("\nConta 1:");
        contaSimples.Depositar(500);
        Console.WriteLine($"Novo saldo: R$ {contaSimples.SaldoAtual:F2}");

        contaSimples.Sacar(1000);
        Console.WriteLine($"Novo saldo: R$ {contaSimples.SaldoAtual:F2}");

        contaSimples.Sacar(200);
        Console.WriteLine($"Novo saldo: R$ {contaSimples.SaldoAtual:F2}");


        Console.WriteLine("\nConta 2:");
        contaCorrente.Depositar(500);
        Console.WriteLine($"Novo saldo: R$ {contaCorrente.SaldoAtual:F2}");

        contaCorrente.Sacar(4000);
        Console.WriteLine($"Novo saldo: R$ {contaCorrente.SaldoAtual:F2}");

        contaCorrente.Sacar(2000);
        Console.WriteLine($"Novo saldo: R$ {contaCorrente.SaldoAtual:F2}");

    }

    public class ContaBancaria
    {
        public string Banco {get; private set;}
        public int Agencia {get; private set;}
        public int Conta {get; private set;}
        public double SaldoAtual {get; protected set;}

        public ContaBancaria(string banco, int agencia, int conta, double saldoAtual)
        {
            this.Banco = banco;
            this.Agencia = agencia;
            this.Conta = conta;
            this.SaldoAtual = saldoAtual;
        }


        public void Depositar(double Valor)
        {
            SaldoAtual += Valor; 
            // SaldoAtual = SaldoAtual + Valor 
        }

        public virtual void Sacar(double Valor)
        {
            if(Valor <= SaldoAtual)
            {
                SaldoAtual -= Valor;
                // SaldoAtual = SaldoAtual -= Valor;
            }
            else
            {
                Console.WriteLine("\nSALDO INSUFICIENTE!");
            }
        }
    }
    public class ContaCorrente : ContaBancaria
    {
        public double Limite {get; private set;}

        public ContaCorrente(string banco, int agencia, int conta, double saldoAtual, double limite) : base(banco, agencia, conta, saldoAtual)
        {
            this.Limite = limite;
        }

        public override void Sacar(double Valor)
        {
            if(Valor <= (SaldoAtual + Limite))
            {
                SaldoAtual -= Valor;
                // SaldoAtual = SaldoAtual -= Valor;
            }
            else
            {
                Console.WriteLine("\nLIMITE E SALDO INSUFICIENTE!");
            }
        }
    }
}