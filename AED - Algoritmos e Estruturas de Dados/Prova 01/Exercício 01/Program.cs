using System;
using System.IO;

namespace Exercício_01
{
    class Program
    {
        static void lerArquivo () {
            string linha;
            StreamReader ler = new StreamReader("../Arquivos/arq1.txt");
            linha = ler.ReadLine();
            while (linha != null) {
                Console.WriteLine(linha);
                linha = ler.ReadLine();
            }
            ler.Close();
        }
        static void Main(string[] args)
        {
            lerArquivo();
        }
    }
}
