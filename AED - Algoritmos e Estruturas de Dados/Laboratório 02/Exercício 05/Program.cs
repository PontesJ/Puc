using System;

namespace Exercício_05
{
    class Program
    {
        static int soma(int[] vetor, int tam)
        {
            if (tam == 0) return 0;
            if (vetor[tam - 1] % 2 == 0) return vetor[tam - 1] + soma(vetor, tam - 1);
            return soma(vetor, tam - 1);
        }

        static void Main(string[] args)
        {
            int[] vetor = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 05");
            Console.WriteLine("\nA soma dos valores par do vetor é: {0}", soma(vetor, 5));
            Console.WriteLine("================================\n");
        }
    }
}
