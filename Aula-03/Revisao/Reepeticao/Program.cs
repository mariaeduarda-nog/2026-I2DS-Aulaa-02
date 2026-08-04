internal class Program
{
    private static void Main(string[] args)
    {
        /*
           sintaxe:
            enquanta uma condição for verdadeira  execute um conjunto de comeandos

            for -> quando sabemos a quantidade de repetições.
            while -> quando a repetição depende de uma condição.
            do ... while -> quando precisa executar ao menos uma vez o bloco de codigo
        */
        /* laço for: imprimir numeros de 1 ate o 10 */

    Console.WriteLine("imprimir numeros de 1 ate 10, utilizando o laço for.");
    for (int numeros = 1; numeros <= 10; numeros++)
        {
              Console.WriteLine(numeros);
        }

 /* laço for: contagem regressiva */

    Console.WriteLine("imprimir contagem regressiva.");
    for (int numeros = 1; numeros >= 10; numeros--)
        {
              Console.WriteLine(numeros);
        }
    }
}
