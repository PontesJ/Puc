using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, soma = 0, i = 0;
            char repetir;
            do {
                Console.WriteLine("\nExercício 04 - Soma de números indeterminados");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Digite um valor: (zero para encerrar)");
                n1 = double.Parse(Console.ReadLine());
                while (n1 != 0) {
                    soma += n1;
                    i++;
                    Console.WriteLine("Digite um valor: (zero para encerrar)");
                    n1 = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("A soma dos {0} valores lidos é : {1}", i, soma);
                Console.WriteLine("\n Deseja repetir o programa ? (S / N)");
                repetir = Console.ReadKey().KeyChar;
            } while (repetir == 'S' || repetir == 's');
        }
    }
}
