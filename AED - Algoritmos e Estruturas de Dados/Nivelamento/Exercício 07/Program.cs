using System;

namespace Exercício_07
{
    class Program
    {
        static string vogais(string frase)
        {
            if (frase == "") return "";
            if (frase[frase.Length - 1] == 'a' || frase[frase.Length - 1] == 'A') return vogais(frase.Substring(0, frase.Length - 1)) + '&';
            return vogais(frase.Substring(0, frase.Length - 1)) + frase[frase.Length - 1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 07");
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            frase = vogais(frase);
            Console.WriteLine(frase);
        }
    }
}
