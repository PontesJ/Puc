using System;

namespace Exercício_06
{
    class Program
    {
        static string vogais(string frase)
        {
            if (frase == "") return "";
            if (frase[frase.Length - 1] == 'a' || frase[frase.Length - 1] == 'e' || frase[frase.Length - 1] == 'i' || frase[frase.Length - 1] == 'o' || frase[frase.Length - 1] == 'u') return vogais(frase.Substring(0, frase.Length - 1));
            return vogais(frase.Substring(0, frase.Length - 1)) + frase[frase.Length - 1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 06");
            Console.Write("\nDigite uma palavra para tirar as vogais: ");
            string palavra = Console.ReadLine();
            Console.WriteLine("\nA palavra: {0}, sem vogais é: {1}", palavra, vogais(palavra));
            Console.WriteLine("================================\n");
        }
    }
}
