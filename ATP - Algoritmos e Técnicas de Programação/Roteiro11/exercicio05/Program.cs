using System;
using System.IO;

namespace exercicio05
{
    class Program
    {
        static void LerMatriz (int [,] Matriz) {
            for (int i = 0; i < Matriz.GetLength(0); i++) {
                for (int j = 0; j < Matriz.GetLength(1); j++) {
                    Console.Write("Digite o {0}° valor da {1}° linha: ", j + 1, i + 1);
                    Matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void lerArquivo () {
            string linha;
            StreamReader ler = new StreamReader("C:\\Users\\joaog\\Documents\\Puc\\Lab\\Roteiro11\\textos\\mat.txt");
            linha = ler.ReadLine();
            while (linha != null) {
                Console.WriteLine(linha);
                linha = ler.ReadLine();
            }
            ler.Close();
        }
        static void Main(string[] args) {
            lerArquivo();
            int [,] Matriz = new int [3,3];
            LerMatriz(Matriz);
            StreamWriter escrever = new StreamWriter("C:\\Users\\joaog\\Documents\\Puc\\Lab\\Roteiro11\\textos\\mat.txt");
            for (int i = 0; i < Matriz.GetLength(0); i++) {
                for (int j = 0; j < Matriz.GetLength(1); j++) {
                    escrever.Write(Matriz[i,j] + " ");
                }
                escrever.Write("\n");
            }
            escrever.Close();
            lerArquivo();
        }
    }
}
