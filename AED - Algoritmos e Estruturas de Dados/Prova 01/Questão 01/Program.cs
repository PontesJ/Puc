using System;
using System.IO;

namespace Questão_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Questão 01");
            Console.WriteLine("\nDigite um texto: ");
            string texto = Console.ReadLine();
            StreamReader ler = new StreamReader("../Arquivos/arq1.txt");
            string linha = ler.ReadLine();
            while (linha != null)
            {
                
                linha = ler.ReadLine();
            }
            ler.Close();
        }
    }
}
