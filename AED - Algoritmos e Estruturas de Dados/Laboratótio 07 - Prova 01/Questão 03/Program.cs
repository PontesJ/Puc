using System;
using System.IO;

namespace Questão_03
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader ler = new StreamReader("../Arquivos/entrada.txt");
            StreamWriter escrever = new StreamWriter("../Arquivos/saida.txt");
            string linha = ler.ReadLine();
            while (linha != null)
            {
                char[] vetor = new char[linha.Length];
                for (int i = 0, j = linha.Length - 1; i < linha.Length; i++, j--)
                    vetor[j] = linha[i];
                for (int i = 0; i < vetor.Length; i++)
                    escrever.Write(vetor[i]);
                escrever.WriteLine();
                linha = ler.ReadLine();
            }
            escrever.Close();
            ler.Close();
        }
    }
}
