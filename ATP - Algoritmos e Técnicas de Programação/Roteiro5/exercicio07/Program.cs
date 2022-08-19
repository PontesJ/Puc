using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 10, n1, soma = 0;
            Console.WriteLine("\nExercício 07 - Soma de 10 números");
            Console.WriteLine("---------------------------------");
            while (cont > 0) {
                Console.WriteLine("Digite um número:");
                n1 = int.Parse(Console.ReadLine());
                soma += n1;
                cont--;
            }
            Console.WriteLine("A soma desses números é {0}", soma);
        }
    }
}
