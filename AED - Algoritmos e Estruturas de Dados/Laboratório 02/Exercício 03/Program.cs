using System;

namespace Exercício_03
{
    class Program
    {
        static int poten(int x, int y)
        {
            if (y == 1) return x;
            int aux = x * poten(x, y - 1);
            return aux;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 03");
            Console.Write("\nInsira o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("\n{0} elevado a {1} é: {2}", x, y, poten(x, y));
            Console.WriteLine("================================\n");
        }
    }
}
