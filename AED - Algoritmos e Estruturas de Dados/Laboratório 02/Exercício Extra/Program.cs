using System;

namespace Exercício_Extra
{
    class Program
    {
        static int Fibonacci(int x)
        {
            if (x <= 0) return 0;
            if (x == 1) return 1;
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício Extra");
            Console.Write("\nDigite o número da posição que deseja encontrar na sequência de Fibonacci: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nA posição {0}° corresponde ao número {1} na sequência de Fibonacci", n, Fibonacci(n));
            Console.WriteLine("\n================================");
        }
    }
}
