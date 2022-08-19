using System;

namespace exercicio01
{
    class Program
    {
        static void LeVetor(float []vetor, int a) {
            if (a == 1) {
                for (int i = 0; i < vetor.Length; i++ ) {
                    Console.Write("Entre com o {0} número do primeiro conjunto: ", i+1);
                    vetor[ i ] = float.Parse(Console.ReadLine());
                }
            }
            else {
                for (int i = 0; i < vetor.Length; i++ ) {
                    Console.Write("Entre com o {0} número do segundo conjunto: ", i+1);
                    vetor[ i ] = float.Parse(Console.ReadLine());
                }
            }
        }

        static void comp (float []vetorC, float []vetorB, float []vetorA) {
            for (int i = 0; i < vetorC.Length; i++) {
                if (vetorA[i] < vetorB[i]) vetorC[i] = vetorA[i];
                else vetorC[i] = vetorB[i];
            }
        }
        
        static void Main(string[] args)
        {
            float []vetorA = new float [10];
            float []vetorB = new float [10];
            float []vetorC = new float [10];
            Console.WriteLine("\nExercício 01 - Soma de conjuntos");
            Console.WriteLine("--------------------------------");
            LeVetor(vetorA, 1);
            Console.WriteLine("--------------------------------");
            LeVetor(vetorB, 0);
            comp(vetorC, vetorB, vetorA);
            Console.Write("O menor número dos conjunto é: ");
            for (int i = 0; i < vetorC.Length; i++) Console.Write(vetorC[i] + " ");
        }
    }
}
