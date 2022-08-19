using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i;
            Console.WriteLine("\nExercício 01 - Números no Intervalo");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Escreva o maior número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o menor número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n-----------------------");
            Console.Write("Os números no intervalo desses dois valores são:");
            Console.WriteLine("\n");
            i = n2;
            while (i < n1 - 1) {
                i ++;
                Console.WriteLine(i);
            }
        }
    }
}
