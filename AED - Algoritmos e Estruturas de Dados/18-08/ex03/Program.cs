using System;

namespace ex03
{
    class Program
    {
        static int poten (int x, int y) {
            if (y == 1) return x;
            int aux = x * poten (x, y-1);
            return aux;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(poten(3, 3));
        }
    }
}
