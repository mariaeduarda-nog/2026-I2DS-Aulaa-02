internal class Program
{
    private static void Main(string[] args)
    {
        // Primeira Conta : ContaBancaria (Sem Limite)
        ContaBancaria contaSimples = new ContaBancaria();
        contaSimples.Banco = "Banco do Brasil";
        contaSimples.Agencia = 1234;
        contaSimples.Conta = 100011;
        contaSimples.SaldoAtual = 500.00;

        // Segunda Conta : ContaCorrente (Com Limite)
        ContaCorrente contaCorrente = new ContaCorrente();
        contaCorrente.Banco = "Itaú";
        contaCorrente.Agencia = 2444;
        contaCorrente.Conta = 222333;
        contaCorrente.SaldoAtual = 1500.00;
        contaCorrente.Limite = 3000.00;

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
    }

    public class ContaBancaria
    {
        public string Banco {get; set;}
        public int Agencia {get; set;}
        public int Conta {get; set;}
        public double SaldoAtual {get;set;}

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
        public double Limite {get; set;}

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