using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double soma = 0, i;
            Console.WriteLine("\nExercício 02 - Formula");
            Console.WriteLine("----------------------");
            Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++) {
                soma = soma +  1.0 / i;
            }
            Console.WriteLine("O resultado desse somatório é {0}", soma);
        }
    }
}
