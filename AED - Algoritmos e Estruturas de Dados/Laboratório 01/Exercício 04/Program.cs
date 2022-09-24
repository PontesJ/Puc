using System;

namespace Exercício_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 04");
            int[,] Matriz = new int[5, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            int somaL = 0, somaC = 0;
            Console.WriteLine("Soma Linhas\n");
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++) somaL += Matriz[i, j];
                Console.WriteLine("A soma da {0}° linha é {1}", i + 1, somaL);
                somaL = 0;
            }
            Console.WriteLine("\nSoma Colunas\n");
            for (int i = 0; i < Matriz.GetLength(1); i++)
            {
                for (int j = 0; j < Matriz.GetLength(0); j++) somaC += Matriz[j, i];
                Console.WriteLine("A soma da {0}° coluna é {1}", i + 1, somaC);
                somaC = 0;
            }
            Console.WriteLine("================================\n");
        }
    }
}
