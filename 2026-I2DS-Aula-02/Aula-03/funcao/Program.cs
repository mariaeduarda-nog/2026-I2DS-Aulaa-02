internal class Program
{
    private static void Main(string[] args)
    {
        Ola("Cristiano");
        Ola("Maria");
        Ola("João");

        Console.WriteLine("A soma de 5 e 3 é: " + Calcular(5,3, "+"));
        Console.WriteLine("A subtracao de 5 e 3 é: " + Calcular(5,3, "-"));
         Console.WriteLine("A subtracao de 5 e 3 é: " + Calcular(5,3, "$"));

    }
    // Função sem retorno e sem parametros
    // public static void Ola()
    // {
    //     Console.WriteLine("Olá, Seja bem vindo!");
    // }

    // Função com parametro nome e sem retorno
    public static void Ola(string nome)
    {
        Console.WriteLine("Olá " + nome  +", Seja bem vindo(a)!");
    }

    public static double Calcular(double num1, double num2, string operador)
    {
        
        double resultado=0;

        switch (operador)
        {
            case "+": 
                resultado = num1 + num2;
                break;
            case "-": 
                resultado = num1 - num2;
                break;
            case "*": 
                resultado = num1 * num2;
                break;
            case "/": 
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Operador informado não é válido.");
                break;
        }
        return resultado;
    }

}