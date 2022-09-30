using System;

namespace Quick_Sort
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
        static void swap(int[] vetor, int inicio, int tam)
        {
            int aux = vetor[inicio];
            vetor[inicio] = vetor[tam];
            vetor[tam] = aux;
        }
        static void quickSort(int[] vetor, int inicio, int tam)
        {
            if (tam > inicio)
            {
                int pivo = particiona(vetor, inicio, tam);
                quickSort(vetor, inicio, pivo - 1);
                quickSort(vetor, pivo + 1, tam);
            }
        }
        static int particiona(int[] vetor, int inicio, int tam)
        {
            int pivo = vetor[tam];
            int i = (inicio - 1);
            for (int j = inicio; j <= tam - 1; j++)
            {
                if (vetor[j] < pivo)
                {
                    i++;
                    swap(vetor, i, j);
                }
            }
            swap(vetor, i + 1, tam);
            return (i + 1);
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int[] vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Quick Sort");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            quickSort(vetor, 0, tam - 1);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}