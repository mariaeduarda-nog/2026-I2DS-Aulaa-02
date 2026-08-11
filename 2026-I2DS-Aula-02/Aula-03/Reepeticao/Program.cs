using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Sintaxe:
                Enquanto uma condição for verdadeira

                    execute um conjunto de comandos   

            for -> Quando sabemos a quantidade de repetições.
            while -> Quando a repetição depende de uma condição.
            do ... while -> Quando precisa executar ao menos uma vez o
                            bloco de codigo     
        */

        /* Laço for: Imprimir numeros de 1 até o 10*/

        Console.WriteLine("Imprimir numeros de 1 até 10, utilizando o laço for.");
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }

        /* Laço for: Contagem Regressiva de 10 ate 0*/

        Console.WriteLine("Imprimir Contagem Regressiva.");
        for (int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }

        /*******************************************************/
        Console.WriteLine("Imprimir numeros de 1 até 10, utilizando o laço while.");

        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        /* Solicitar a senha até acertar */
        string senha = "";
        while(senha != "2444")
        {
            Console.Write("Digite a Senha: ");
            senha = Console.ReadLine();
        }
        Console.WriteLine("Acesso permitido!");

/******************************************************************/
       int Num;
       do
        {
          Console.Write("digite um numero positivo: ");
          Num = int.Parse(Console.ReadLine());
        }while(Num <=0);


    }
}