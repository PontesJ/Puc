using System;
using System.IO;

namespace Questão_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int iguais = 0, diferente = 0;
            Console.WriteLine("\n================================");
            Console.WriteLine("Questão 01");
            Console.Write("\nDigite um texto: ");
            string texto = Console.ReadLine();
            string[] valores = texto.Split(" ");
            StreamReader ler = new StreamReader("../Arquivos/arq1.txt");
            string linha = ler.ReadLine();
            while (linha != null)
            {
                string[] palavras = linha.Split(" ");
                for (int i = 0; i < valores.Length; i++)
                    for (int j = 0; j < palavras.Length; j++)
                        if (palavras[j] == valores[i])
                            iguais++;
                diferente += palavras.Length;
                linha = ler.ReadLine();
            }
            ler.Close();
            Console.WriteLine("Existem {0} termos iguais", iguais);
            Console.WriteLine("Existem {0} termos diferentes", diferente - iguais);
            Console.WriteLine("================================\n");
        }
    }
}
