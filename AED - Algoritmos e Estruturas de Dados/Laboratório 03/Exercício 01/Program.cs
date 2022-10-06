using System;

namespace Exercício_01
{
    class Program
    {
        static int[] divisor(int[] vetor, int pos)
        {
            if (pos == 1)
                return vetor;

            if (pos % 2 == 0)
            {
                int[] vetor1 = new int[pos / 2];
                int[] vetor2 = new int[pos / 2];
                for (int i = 0; i < vetor1.Length; i++) vetor1[i] = vetor[i];
                for (int i = 0; i < vetor2.Length; i++) vetor2[i] = vetor[i + pos / 2];
                vetor1 = divisor(vetor1, pos / 2);
                vetor2 = divisor(vetor2, pos / 2);
                vetor = ordenar(vetor1, vetor2);
            }
            else
            {
                int[] vetor1 = new int[pos / 2];
                int[] vetor2 = new int[(pos / 2) + 1];
                for (int i = 0; i < vetor1.Length; i++) vetor1[i] = vetor[i];
                for (int i = 0; i < vetor2.Length; i++)vetor2[i] = vetor[i + pos / 2];
                vetor1 = divisor(vetor1, pos / 2);
                vetor2 = divisor(vetor2, pos / 2 + 1);
                vetor = ordenar(vetor1, vetor2);
            }
            return vetor;
        }
        static int[] ordenar(int[] vetor1, int[] vetor2)
        {
            int[] vetorAux = new int[vetor1.Length + vetor2.Length];
            for (int i = 0, j = 0, k = 0; k < vetorAux.Length; k++)
            {
                if (i == vetor1.Length)
                {
                    vetorAux[k] = vetor2[j];
                    j++;
                }
                else if (j == vetor2.Length)
                {
                    vetorAux[k] = vetor1[i];
                    i++;
                }
                else if (vetor1[i] < vetor2[j])
                {
                    vetorAux[k] = vetor1[i];
                    i++;
                }
                else
                {
                    vetorAux[k] = vetor2[j];
                    j++;
                }
            }
            return vetorAux;
        }
        static void criaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Random rand = new Random();
                vetor[i] = rand.Next(0, 10);
            }
        }
        const int tam = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 01");
            int[] vetor = new int[tam];
            criaVetor(vetor);
            Console.Write("\nO vetor: ");
            for(int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            vetor = divisor(vetor, tam);
            Console.Write("\nOrdenado: ");
            for(int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}