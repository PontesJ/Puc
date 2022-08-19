using System;

namespace exercicio04
{
    class Program
    {
        static void conversor (int segundos, ref int h, ref int m, ref int s) {
            h = segundos / 3600;
            m = segundos % 3600 / 60;
            s = segundos % 3600 % 60;
        }
        /* static void Main(string[] args)
        {
            int s = 9610, h = 0, m = 0, seg = 0;
            conversor(s, ref h, ref m, ref seg);
            Console.WriteLine("{0} {1} {2}", h, m, seg);
        } */
    }
}
