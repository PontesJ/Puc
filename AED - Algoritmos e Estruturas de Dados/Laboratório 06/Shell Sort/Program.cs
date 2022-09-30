using System;

namespace Shell_Sort {
    class Program
    {
        static void criaVetor(int []vetor) {
            for (int i = 0; i < vetor.Length; i++) {
                Random rand = new Random();
                vetor[i] = rand.Next(0,10);
            }
        }
        static void shellSort(int []vetor) {
            for (int gap = vetor.Length/2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < vetor.Length; i += 1)
                {
                    int aux = vetor[i];
                    int j;
                    for (j = i; j >= gap && vetor[j - gap] > aux; j -= gap) vetor[j] = vetor[j - gap];
                    vetor[j] = aux;
                }
            }
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int []vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Shell Sort");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            shellSort(vetor);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}