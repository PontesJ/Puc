using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("\nExercício 01 - Qual o maior número?");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Informe o primeiro número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Infome o segundo número:");
            n2 = double.Parse(Console.ReadLine());
            if (n1 < n2) {
                Console.WriteLine("O número {0} é o maior", n2);
            } else {
                Console.WriteLine("O número {0} é o maior", n1);
            }
        }
    }
}
