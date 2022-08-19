using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("\nExercício 03 - Par ou Impar");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite um número inteiro:");
            n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0) {
                Console.WriteLine("O número {0} é Par", n1);
            } else {
                Console.WriteLine("O número {0} é Ímpar", n1);
            }
        }
    }
}
