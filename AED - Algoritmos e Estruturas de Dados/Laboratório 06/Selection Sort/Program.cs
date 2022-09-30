using System;

namespace Selection_Sort
{
    class Program
    {
        static void criaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Random rand = new Random();
                vetor[i] = rand.Next(0, 10);
            }
        }
        static void selectionSort(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                int pos = i;
                for (int j = i; j < vetor.Length; j++)
                {
                    if (vetor[j] <= vetor[pos])
                    {
                        pos = j;
                    }
                }
                int aux = vetor[pos];
                vetor[pos] = vetor[i];
                vetor[i] = aux;
            }
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int[] vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Selection Sort");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            selectionSort(vetor);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}