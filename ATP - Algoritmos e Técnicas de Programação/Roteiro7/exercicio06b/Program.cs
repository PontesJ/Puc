using System;

namespace exercicio06b
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j, soma = 0;
            Console.WriteLine("\nExercício 06 - B");
            Console.WriteLine("----------------");
            for (i = 21, j = 250; i <= 250; i++, j--) {
                soma += i/j;
            }
            Console.WriteLine("J = {0}", soma);
        }
    }
}
