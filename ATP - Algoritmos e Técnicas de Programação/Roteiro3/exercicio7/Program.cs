using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, soma;
            Console.WriteLine("\nExercício 07 - Soma entre os dois maiores números");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Informe o Primeiro Número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Número:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Terceiro Número:");
            n3 = double.Parse(Console.ReadLine());
            if (n1 > n2 && n2 > n3) {
                soma = n1 + n2;
                Console.WriteLine("A soma entre os dois maiores números é {0} | {1} + {2} = {3}", soma, n1, n2, soma);
            } else {
                if (n1 > n2 && n3 > n2) {
                    soma = n1 + n3;
                    Console.WriteLine("A soma entre os dois maiores números é {0} | {1} + {2} = {3}", soma, n1, n3, soma);
                } else {
                    soma = n2 + n3;
                    Console.WriteLine("A soma entre os dois maiores números é {0} | {1} + {2} = {3}", soma, n2, n3, soma);
                }
            }
        }
    }
}
