using System;

namespace Bubble_Sort
{
    class Program
    {
        static void criaVetor(int []vetor) {
            for (int i = 0; i < vetor.Length; i++) {
                Random rand = new Random();
                vetor[i] = rand.Next(0,10);
            }
        }
        static void bubbleSort(int []vetor) {
            for (int i = 0; i < vetor.Length; i++) {
                for (int j = 0; j < vetor.Length; j++) {
                    if (vetor[i] < vetor[j]) {
                        int aux = vetor[j];
                        vetor[j] = vetor[i];
                        vetor[i] = aux;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int []vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Bubble Sort");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            bubbleSort(vetor);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}