using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("\nExercício 06 - Maior e Menor entre Três Números");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Informe o Primeiro Número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Número:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Terceiro Número:");
            n3 = double.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3) {
                Console.WriteLine("O número {0} é maior que {1} e {2}", n1, n2, n3);
            } else {
                if (n2 > n1 && n2 > n3) {
                    Console.WriteLine("O número {0} é maior que {1} e {2}", n2, n1, n3);
                } else {
                    Console.WriteLine("O número {0} é maior que {1} e {2}", n3, n1, n2);
                }
            }
        }
    }
}
