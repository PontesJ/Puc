using System;

namespace Exercício_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 02");
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) Console.WriteLine("O número {0} é par", n);
            else Console.WriteLine("O número {0} é impar", n);
        }
    }
}
