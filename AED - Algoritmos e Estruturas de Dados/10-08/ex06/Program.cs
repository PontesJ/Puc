using System;

namespace ex06
{
    class Program
    {
        static void expo(ref int x, ref int y)
        {
            int aux = 1;
            for (int i = 0; i < y; i++)
            {
                aux *= x;
            }
            x = aux;
        }
        static void Main(string[] args)
        {
            int x = 5, y = 2;
            expo(ref x, ref y);
            Console.WriteLine(x);
        }
    }
}
