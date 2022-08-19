using System;

namespace ex01
{
    class Program
    {
        static int fat (int n) {
            if (n==2) return 2;
            int aux = n * fat(n-1);
            return aux;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(fat(5));
        }
    }
}
