using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("\nExercício 02 - Positivo, Negativo ou Zero");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Informe um número qualquer:");
            n1 = double.Parse(Console.ReadLine());
            if (n1 == 0) {
                Console.WriteLine("O número é nulo");
            } else {
                if (n1 < 0) {
                    Console.WriteLine("O número {0} é negativo", n1);
                } else {
                    Console.WriteLine("o número {0} é positivo", n1);
                }
            }
        }
    }
}
