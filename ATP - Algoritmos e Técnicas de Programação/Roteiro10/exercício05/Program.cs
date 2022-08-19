using System;

namespace exercício05
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
        static void SomaDiagonalP (int [,] Matriz) {
           int soma = 0;
            for (int i = 0; i < Matriz.GetLength(0); i++) {
                soma += Matriz[i,i];
            }
            Console.WriteLine("A soma da Diagonal Principal dessa Matriz é {0}", soma);
        }
        static void SomaDiagonalS (int [,] Matriz) {
            int soma = 0;
            for (int i = (Matriz.GetLength(0) - 1), j = 0; j < Matriz.GetLength(1); i--, j++) {
                soma += Matriz[i,j]; 
            }
            Console.WriteLine("A soma da Diagonal Secundaria dessa Matriz é {0}", soma);
        }
        static void Main(string[] args)
        {
            int [,]MatrizC = new int[4,4];
            LerMatriz(MatrizC);
            SomaDiagonalP(MatrizC);
            SomaDiagonalS(MatrizC);
        }
    }
}
