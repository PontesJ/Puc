using System;

namespace exercício02
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
        
        static void MaiorMatriz (int [,] MatrizA, int [,] MatrizB, int [,] MatrizC) {
            for (int i = 0; i < MatrizC.GetLength(0); i++) {
                for (int j = 0; j < MatrizC.GetLength(1); j++) {
                    MatrizC[i,j] = (MatrizA[i,j] > MatrizB[i,j]) ?  MatrizA[i,j] : MatrizB[i,j];
                }
            }
        }

        static void Main(string[] args)
        {
            int [,] MatrizA = new int [4,4];
            int [,] MatrizB = new int [4,4];
            int [,] MatrizC = new int [4,4];
            LerMatriz(MatrizA);
            LerMatriz(MatrizB);
            MaiorMatriz(MatrizA, MatrizB, MatrizC);
        }
    }
}
