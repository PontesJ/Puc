using System;

namespace Insertion_Sort
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
        static void insertionSort(int[] vetor)
        {
            for (int i = 1; i < vetor.Length; i++)
            {
                int j, aux = vetor[i];
                for (j = i; j > 0 && vetor[j - 1] > aux; j--) vetor[j] = vetor[j - 1];
                vetor[j] = aux;
            }
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int[] vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Insertion Sort");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            insertionSort(vetor);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}