using System;

namespace exercicio03
{
    class Program
    {
        
        static int conversor (int h, int m, int s) {
            return h * 3600 + m * 60 + s;
        }
        /* static void Main(string[] args)
        {
            int h, m, s, c;
            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            c = conversor(h, m, s);
            Console.WriteLine(c);
        } */
    }
}
