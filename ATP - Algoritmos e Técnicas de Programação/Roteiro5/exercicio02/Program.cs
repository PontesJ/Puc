using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("\nExercício 02 - Múltiplos de 7 menores que 1000");
            Console.WriteLine("----------------------------------------------");
            n = 7;
            while (n <= 1000) {
                Console.WriteLine(n);
                n += 7;
            }
        }
    }
}
