using System;

namespace Exercício_04
{
    class Program
    {
        static int letras(string frase, char letra)
        {
            if (frase == "") return 0;
            if (frase[0] == letra) return letras(frase.Substring(1), letra) + 1;
            return letras(frase.Substring(1), letra);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 04");
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            Console.Write("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine("\nA letra {0} aparece {1} vezes na palavra: {2}", letra, letras(palavra, letra), palavra);
            Console.WriteLine("================================\n");
        }
    }
}
