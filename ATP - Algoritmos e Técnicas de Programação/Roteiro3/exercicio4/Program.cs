using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("\nExercício 04 - Valor Absoluto");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Informe um número:");
            n1 = double.Parse(Console.ReadLine());
            if (n1 < 0) {
                n1 = n1 * -1;
                Console.WriteLine("O valor absoluto desse número é {0}", n1);
            } else {
                Console.WriteLine("O valor absoluto desse número é {0}", n1);
            }
        }
    }
}
