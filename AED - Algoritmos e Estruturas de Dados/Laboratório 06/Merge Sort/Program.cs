using System;

namespace Merge_Sort
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
        static void mergeSort(int[] vetor, int inicio, int tam)
        {
            if (inicio < tam)
            {
                int metade = inicio + (tam - inicio) / 2;
                mergeSort(vetor, inicio, metade);
                mergeSort(vetor, metade + 1, tam);
                organizador(vetor, inicio, metade, tam);
            }
        }
        static void organizador(int[] vetor, int inicio, int metade, int tam)
        {
            int i, j, k;
            int parte1 = metade - inicio + 1;
            int parte2 = tam - metade;
            int[] vetor1 = new int[parte1];
            int[] vetor2 = new int[parte2];
            for (i = 0; i < parte1; i++) vetor1[i] = vetor[inicio + i];
            for (j = 0; j < parte2; j++) vetor2[j] = vetor[metade + 1 + j];
            i = 0;
            j = 0;
            k = inicio;
            for (; i < parte1 && j < parte2; k++)
            {
                if (vetor1[i] <= vetor2[j])
                {
                    vetor[k] = vetor1[i];
                    i++;
                }
                else
                {
                    vetor[k] = vetor2[j];
                    j++;
                }
            }
            for (; i < parte1; i++, k++) vetor[k] = vetor1[i];
            for (; j < parte2; j++, k++) vetor[k] = vetor2[j];
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int[] vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Merge Sort");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            mergeSort(vetor, 0, vetor.Length - 1);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}