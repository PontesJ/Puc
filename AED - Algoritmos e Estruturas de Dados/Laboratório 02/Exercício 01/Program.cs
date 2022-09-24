using System;

namespace Exercício_01
{
    class Program
    {
        static int fat(int n)
        {
            if (n == 2) return 2;
            int aux = n * fat(n - 1);
            return aux;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 01");
            Console.Write("\nEscreva um número para saber seu fatorial: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nO fatorial de {0} é: {1}", x, fat(x));
            Console.WriteLine("================================\n");
        }
    }
}