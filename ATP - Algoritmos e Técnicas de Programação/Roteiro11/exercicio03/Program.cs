using System;
using System.IO;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args) {
            string linha;
            int i = 0;
            StreamReader ler = new StreamReader("../textos/LOREM.txt");
            linha = ler.ReadLine();
            while (linha != null) {
                Console.WriteLine(linha);
                linha = ler.ReadLine();
                if (linha != "" && i % 20 == 0) {
                    if (i > 0) {
                        Console.WriteLine("Mais... [ENTER]");
                        Console.ReadKey();
                    }
                }
                i++;
            }
            ler.Close();
        }
    }
}