using System;
using System.IO;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args) {
            string linha;
            StreamReader ler = new StreamReader("C:\\Users\\joaog\\Documents\\Puc\\Lab\\Roteiro11\\textos\\LOREM.txt");
            linha = ler.ReadLine();
            while (linha != null) {
                Console.WriteLine(linha);
                linha = ler.ReadLine();
            }
            ler.Close();
        }
    }
}
