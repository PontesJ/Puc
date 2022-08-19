using System;

namespace exercício01
{
    class Program
    {
        static void LerMatriz (int [,] Matriz) {
            for (int i = 0; i < Matriz.GetLength(0); i++) {
                for (int j = 0; j < Matriz.GetLength(1); j++) {
                    Console.WriteLine("Digite o {0}° valor da {1}° linha", j + 1, i + 1);
                    Matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void ImprimirMatriz (int [,] Matriz) {
            for (int i = 0; i < Matriz.GetLength(0); i++) {
                for (int j = 0; j < Matriz.GetLength(1); j++) {
                    Console.Write(Matriz[i,j] + " ");
                }
            }
        }
        
        /*
        static void Main(string[] args)
        {
            int [,] Matriz = new int [2,2];
            LerMatriz(Matriz);
            ImprimirMatriz(Matriz);
        }
        */
    }
}
