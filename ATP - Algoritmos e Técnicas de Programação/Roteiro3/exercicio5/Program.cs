using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("\nExercício 05 - Divisível por 2 e por 7 ao mesmo tempo");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Informe um número inteiro:");
            n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0 && n1 % 7 == 0) {
                Console.WriteLine("O número {0} é divisível por 2 e por 7 ao mesmo tempo", n1);
            } else {
                Console.WriteLine("O número {0} não é divisível por 2 e por 7 ao mesmo tempo", n1);
            }
        }
    }
}
