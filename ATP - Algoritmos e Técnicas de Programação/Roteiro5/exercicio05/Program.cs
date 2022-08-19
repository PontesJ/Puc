using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("\nExercício 05 - Números Ímpares");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Os números ímpares menores que {0} são:", n1);
            while (n1 >= 1) {
                if (n1 % 2 == 1) Console.WriteLine(n1);
                n1 --;
            }
        }
    }
}
