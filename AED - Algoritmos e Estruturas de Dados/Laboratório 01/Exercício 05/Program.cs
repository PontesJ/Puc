using System;

namespace Exercício_05
{
    class Program
    {
        static void Fatorial(int N, int Fat)
        {
            if (N >= 0)
            {
                if (N == 0) Console.WriteLine("\nO fatorial de 0 é: 1");
                else
                {
                    int Cont = N;
                    while (Cont > 1)
                    {
                        N = N * (Cont - 1);
                        Cont--;
                    }
                    Console.WriteLine("\nO fatorial de {0} é: {1}", Fat, N);
                }
            }
            else Console.WriteLine("Não é possível calcular fatorial de número negativo");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 05");
            Console.Write("Entre com um valor para cálculo do fatorial: ");
            int N = int.Parse(Console.ReadLine());
            Fatorial(N, N);
            Console.WriteLine("================================\n");
        }
    }
}
