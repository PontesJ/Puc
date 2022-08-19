using System;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, x, num;
            Console.WriteLine("\nExercício 06 - Fatorial de um número");
            Console.WriteLine("------------------------------------");
            do {
                Console.WriteLine("Digite um número:");
                n1 = int.Parse(Console.ReadLine());
            } while (n1 < 0);
            Console.WriteLine("");
            x = n1;
            num = n1;
            if (n1 != 0) {
                while (x > 1) {
                    x--;
                    n1 = n1 * x; 
                }
                Console.WriteLine("O fatorial de {0} é {1}",num ,n1);
            } else Console.WriteLine("O fatorial de 0 é 1");
        }
    }
}
