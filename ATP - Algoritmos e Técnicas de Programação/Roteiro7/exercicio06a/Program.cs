using System;

namespace exercicio06a
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j, soma = 0;
            Console.WriteLine("\nExercício 06 - A");
            Console.WriteLine("----------------");
            for (i = 1, j = 1; j <= 50; i += 2, j++) {
                soma += i/j;
            }
            Console.WriteLine("G = {0}", soma);
        }
    }
}
