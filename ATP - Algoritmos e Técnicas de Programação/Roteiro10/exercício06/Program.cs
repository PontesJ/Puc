using System;

namespace exercício06
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
        static void Transposta (int [,] MatrizC, int [,] MatrizD) {
            for (int i = 0; i < MatrizC.GetLength(0); i++) {
                for (int j = 0; j < MatrizC.GetLength(1); j++) {
                    MatrizD[i,j] = MatrizC [j,i];
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
            int [,] MatrizC = new int [4,4];
            int [,] MatrizD = new int [4,4];
            LerMatriz(MatrizC);
            Transposta(MatrizC, MatrizD);
            ImprimirMatriz(MatrizD);
        }
    }
}
