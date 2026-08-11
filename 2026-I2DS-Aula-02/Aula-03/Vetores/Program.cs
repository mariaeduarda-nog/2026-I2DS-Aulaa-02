using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
/* Vetores e matrizes
       Vetor é uma estrutura de dados utilizada para armazenar varios valores de um mesmo tipo dentro dentro de uma unica variavel

       tipo[] nome_vetor = new tipo[tamanho];
*/

/* Iniciar vetor -> Lista de frutas */

string[] listafrutas = {"Maca","Manga","Morango","Melancia","Melao",};

Console.WriteLine("Acessar o terceiro elemento da lista ");
Console.WriteLine(listafrutas[2]);

Console.WriteLine("Acessar o segundo elemento da lista ");
listafrutas[1] = "Banana";
for (int indice = 0; indice < listafrutas.Count(); indice++ )
Console.WriteLine(listafrutas[indice]);


/********************************************************************/
foreach (string fruta in listafrutas)
        {
            Console.WriteLine(fruta);
        }
    }
}