using System;

namespace Exercício_04
{
    class Program
    {
        static int[] divisor(int[] vetor)
        {
            if (vetor.Length == 1)
                return vetor;

            if (vetor.Length % 2 == 0)
            {
                int[] vetor1 = new int[vetor.Length / 2];
                int[] vetor2 = new int[vetor.Length / 2];
                for (int i = 0; i < vetor1.Length; i++) vetor1[i] = vetor[i];
                for (int i = 0; i < vetor2.Length; i++) vetor2[i] = vetor[i + vetor.Length / 2];
                vetor1 = divisor(vetor1);
                vetor2 = divisor(vetor2);
                ordenar(vetor, vetor1, vetor2);
            }
            else
            {
                int[] vetor1 = new int[vetor.Length / 2];
                int[] vetor2 = new int[vetor.Length / 2 + 1];
                for (int i = 0; i < vetor1.Length; i++) vetor1[i] = vetor[i];
                for (int i = 0; i < vetor2.Length; i++)vetor2[i] = vetor[i + vetor.Length / 2];
                vetor1 = divisor(vetor1);
                vetor2 = divisor(vetor2);
                ordenar(vetor, vetor1, vetor2);
            }
            return vetor;
        }
        static void ordenar(int[] vetor, int[] vetor1, int[] vetor2)
        {
            for (int i = 0, j = 0, k = 0; i < vetor.Length; i++)
            {
                if (k == vetor1.Length)
                {
                    vetor[i] = vetor2[j];
                    j++;
                }
                else if (j == vetor2.Length)
                {
                    vetor[i] = vetor1[k];
                    k++;
                }
                else if (vetor1[k] < vetor2[j])
                {
                    vetor[i] = vetor1[k];
                    k++;
                }
                else
                {
                    vetor[i] = vetor2[j];
                    j++;
                }
            }
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
            Console.WriteLine("Exercício 04");
            int[] vetor = new int[tam];
            criaVetor(vetor);
            Console.Write("\nO vetor: ");
            for(int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            vetor = divisor(vetor);
            Console.Write("\nOrdenado: ");
            for(int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}