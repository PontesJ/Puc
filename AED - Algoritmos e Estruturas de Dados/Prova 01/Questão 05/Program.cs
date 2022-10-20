using System;

namespace Questão_05
{
    class Program
    {
        static int funcao(int a, int[] v)
        {
            if (a == 1)
                return v[0];
            else
            {
                int x;
                x = funcao(a-1, v);

                if (x > v[a-1])
                    return x;

                else
                    return v[a-1];
            }
        }
        static void Main(string[] args)
        {
            int[] vetor = new int[7] { 10, 5, 7, 15, 22, 9, 30 };
            Console.WriteLine(funcao(6, vetor));
        }
    }
}
