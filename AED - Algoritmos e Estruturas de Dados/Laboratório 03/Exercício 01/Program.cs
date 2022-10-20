using System;

namespace Exercício_01
{
    class Program
    {
        static int procurar(int[] vetor, int inicio, int tam, int numero, int pos)
        {
            if (inicio <= tam)
            {
                int metade = inicio + (tam - inicio) / 2;
                if (vetor[metade] == numero) return pos = metade + 1;
                if (vetor[metade] > numero) return procurar(vetor, inicio, metade - 1, numero, pos);
                return procurar(vetor, metade + 1, tam, numero, pos);
            }
            pos = -1;
            return pos;
        }
        static void Main(string[] args)
        {
            const int tam = 5;
            int pos = 0;
            int[] vetor = new int[tam] { 10, 20, 30, 40, 50 };
            Console.WriteLine("\n================================================");
            Console.WriteLine("Exercício 01");
            Console.Write("\nDigite o número que deseja procurar no vetor: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nO número {0} se encontra na {1}° posição", n, procurar(vetor, 0, tam - 1, n, pos));
            Console.WriteLine("================================================\n");
        }
    }
}
