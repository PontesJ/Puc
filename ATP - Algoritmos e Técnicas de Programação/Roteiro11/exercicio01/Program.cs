using System;
using System.IO;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args) {
            StreamWriter escrever = new StreamWriter("C:\\Users\\joaog\\Documents\\Puc\\Lab\\Roteiro11\\textos\\POEMAS.txt");
            Console.Write("Digite o poema: ");
            string texto = Console.ReadLine();
            escrever.Write(texto);
            escrever.Close();
        }
    }
}