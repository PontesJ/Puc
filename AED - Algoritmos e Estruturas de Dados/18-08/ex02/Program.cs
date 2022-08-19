using System;

namespace ex02
{
    class Program
    {
        static int mult (int x, int y) {
            if (y == 1) return x;
            int aux = x + mult (x, y-1);
            return aux;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(mult(15, 9));
        }
    }
}
