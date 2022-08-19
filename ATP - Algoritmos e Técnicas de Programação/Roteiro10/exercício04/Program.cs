using System;

namespace exercício04
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

        static double MediaMatriz (int [,] Matriz) {
            double soma = 0;
            for (int i = 0 ; i < Matriz.GetLength(0); i++) {
                for (int j = 0 ; j < Matriz.GetLength(1); j++) {
                    soma += Matriz[i,j];
                }
            }
            return soma / Matriz.Length;
        }
        
        static void Main(string[] args)
        {
            int [,] MatrizA = new int [4,4];
            int [,] MatrizB = new int [4,4];
            double MediaA, MediaB;
            LerMatriz(MatrizA);
            LerMatriz(MatrizB);
            MediaA = MediaMatriz(MatrizA);
            MediaB = MediaMatriz(MatrizB);
        }
    }
}
