using System;

namespace Contagem
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
        static int[] contagem(int[] vetor)
        {
            int minval = vetor[0], maxval = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < minval) minval = vetor[i];
                if (vetor[i] > maxval) maxval = vetor[i];
            }
            int[] cont = new int[maxval - minval + 1];
            for (int i = 0; i < vetor.Length; i++)
            {
                cont[vetor[i] - minval]++;
            }
            for (int i = 1; i < cont.Length; i++) {
                cont[i] += cont[i - 1];
            }
            int[] aux = new int[vetor.Length];
            for (int i = vetor.Length - 1; i >= 0; i--) {
                aux[cont[vetor[i] - minval]-1] = vetor[i];
                cont[vetor[i] - minval]--;
            }
            return aux;
        }
        static void Main(string[] args)
        {
            const int tam = 10;
            int[] vetor = new int[tam];
            criaVetor(vetor);
            Console.WriteLine("\n================================");
            Console.WriteLine("Contagem");
            Console.Write("\nO vetor: ");
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.Write("\nOrdenado: ");
            vetor = contagem(vetor);
            for (int i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);
            Console.WriteLine("\n================================\n");
        }
    }
}
