using System;

namespace exercício07
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
        static void MaiorMatriz (int [,] MatrizA, int [,] MatrizB, int [,] MatrizE) {
            for (int i = 0; i < MatrizE.GetLength(0); i++) {
                for (int j = 0; j < MatrizE.GetLength(1); j++) {
                    MatrizE[i,j] = (MatrizA[i,j] < MatrizB[i,j]) ?  MatrizA[i,j] : MatrizB[i,j];
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
        static void Main(string[] args)
        {
            int [,] MatrizA = new int [4,4];
            int [,] MatrizB = new int [4,4];
            int [,] MatrizE = new int [4,4];
            LerMatriz(MatrizA);
            LerMatriz(MatrizB);
            MaiorMatriz(MatrizA, MatrizB, MatrizE);
            ImprimirMatriz(MatrizE);
        }
    }
}
