using System;

namespace Exercício_01
{
    class Program
    {
        static void organizar(int[] vetor, int inicio, int tam)
        {
            if (inicio < tam)
            {
                int metade = inicio + (tam - inicio) / 2;
                organizar(vetor, inicio, metade);
                organizar(vetor, metade + 1, tam);
                vetor = ordernarVetor(vetor, inicio, metade, tam);
            }
        }
        static int[] ordernarVetor(int[] vetor, int inicio, int metade, int tam)
        {
            int i, j, k;
            int metade1 = metade - inicio + 1;
            int metade2 = tam - metade;
            int[] vetor1 = new int[metade1];
            int[] vetor2 = new int[metade2];
            for (i = 0; i < metade1; i++) vetor1[i] = vetor[inicio + i];
            for (j = 0; j < metade2; j++) vetor2[j] = vetor[metade + 1 + j];
            j = 0;
            k = inicio;
            for (i = 0; i < metade1 && j < metade2; k++)
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
            for (; i < metade1; i++, k++) vetor[k] = vetor1[i];
            for (; j < metade2; j++, k++) vetor[k] = vetor2[j];
            return vetor;
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int[] vetor = new int[tam];
            for (int i = 0; i < vetor.Length; i++)
            {
                Random rand = new Random();
                vetor[i] = rand.Next(0, 10);
            }
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 01");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrganizado: ");
            organizar(vetor, 0, vetor.Length - 1);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}