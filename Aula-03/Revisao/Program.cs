internal class Program
{
    private static void Main(string[] args)
    {
        // Criar uma váriavel
        // Sintaxe: tipo_variavel nome_variavel = valor_variavel

        // Tipos de dados Primarios
        /* int -> Representação de Números inteiros */
        int idade = 21;
        /* double -> Representação de Números Decimais */
        double salario = 10352.25;
        float altura = 1.75f;
        decimal peso = 71.35m;
        /* string -> Representação de um texto alphanumerico*/
        string nome = "Thomaz";
        string celular = "14996667788";
        string cpf = "123.456.789-03";
        /* bool -> Representa um numero Booleano (True or False) */
        bool estudante = true;
        bool temLimite = false;
        /* DateTime -> Representação de Data e Hora */
        DateTime cadastro = new DateTime(2026,08,04,09,15,32);
        DateOnly nascimento = new DateOnly(2010,01,20);

        /* *********************************************************** */
        /* Operadores Matemáticos 
           + -> Somar
           - -> Subtrair
           * -> Multiplicar
           / -> Divisão  
           % -> Resto da Divisão
           ^ -> Exponenciação
           = -> Atribuição
        */

        int n1 = 10;
        int n2 = 3;
        double resultado = 0;

        // Calcular  a soma: 
        resultado = n1 + n2;
        Console.WriteLine("A soma dos dois numeros é: " + resultado);

        // Calcular a subtracao: 
        resultado = n1 - n2;
        Console.WriteLine("A subtração dos dois numeros é: " + resultado);

        // Calcular a multiplicação: 
        resultado = n1 * n2;
        Console.WriteLine("A multiplicação dos dois numeros é: " + resultado);

        // Calcular a divisão: 
        resultado = n1 / n2;
        Console.WriteLine("A divisão dos dois numeros é: " + resultado);

        // Calcular o resto da divisão: 
        resultado = n1 % n2;
        Console.WriteLine("O resto da divisão dos dois numeros é: " + resultado);

        // Calcular a potencia: 
        resultado = n1 ^ n2;
        Console.WriteLine("O numero 1 elevado ao numero 2 é: " + resultado);

        Console.WriteLine("Valor de N1: " + n1);
        
        /** Operador de Incremento ++ **/
        n1++; // Aumento o Numero atual em + 1
        Console.WriteLine("Valor de N1: " + n1);

        /** Operador de Incremento += **/
        n1+=10; // n1 = n1 + 10;
        Console.WriteLine("Valor de N1: " + n1); 

        
        /** Operador de Decremento -- **/
        n1--; // Aumento o Numero atual em + 1
        Console.WriteLine("Valor de N1: " + n1);

        /** Operador de Decremento -= **/
        n1-=10; // n1 = n1 - 10;
        Console.WriteLine("Valor de N1: " + n1); 

        /*****************************************************/
/* Operadores Relacionais -> Reazlizam Comparações */
/* > -> maior que
   < -> menor que
   >= -> maior ou igual 
   <= -> menou ou igual
   == -> igual
   != -> diferentes
   */

   Console.WriteLine("A idade informada e maior que 18? " + (idade > 18));

Console.WriteLine("o peso informado e menor que 60 kg? " + (peso <= 60));

Console.WriteLine("o nome informado e de um estudante? " + (estudante == true));

/***************************************************************/
/* operadores logicos -> permitem combinar duas ou mais condições */
/* && -> operador logico "E" 
 ! -> operador logico de negação
 */

peso = 183;
altura = 183;

Console.WriteLine("Peso: " + peso + " Altura: " + altura);
Console.Write((peso <= 100) && (altura > 180));





    }
}
