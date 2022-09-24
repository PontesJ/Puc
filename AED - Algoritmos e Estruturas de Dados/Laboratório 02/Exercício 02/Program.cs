using System;

namespace Exercício_02
{
    class Program
    {
        static int mult(int x, int y)
        {
            int aux;
            if (y == 0) return 0;
            if (y < 0) aux = x * -1 + mult(x, y + 1);
            else aux = x + mult(x, y - 1);
            return (aux);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 02");
            Console.Write("\nInsira o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("\nA multiplicação de {0} por {1} é: {2}", x, y, mult(x, y));
            Console.WriteLine("================================\n");
        }
    }
}
