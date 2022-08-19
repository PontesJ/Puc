using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 03");
            int[] A = new int[5] { 1, 2, 3, 4, 5 };
            int[] B = new int[5] { 2, 4, 6, 8, 10 };
            int[] C = new int[5];
            int[] D = new int[5];
            int valC = 0, valD = 0, dif = 0;
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] == B[i])
                    {
                        C[valC] = A[j];
                        valC++;
                    }
                    if (A[i] == B[j]) dif++;
                }
                if (dif == 0)
                {
                    D[valD] = A[i];
                    valD++;
                }
                dif = 0;
            }
            Console.WriteLine("\nVetor C:");
            for (int i = 0; i < C.Length; i++)
            {
                if (C[i] != 0)
                {
                    Console.WriteLine(C[i]);
                }
            }
            Console.WriteLine("\nVetor D:");
            for (int i = 0; i < D.Length; i++)
            {
                if (D[i] != 0)
                {
                    Console.WriteLine(D[i]);
                }
            }
            Console.WriteLine("================================");
        }
    }
}
