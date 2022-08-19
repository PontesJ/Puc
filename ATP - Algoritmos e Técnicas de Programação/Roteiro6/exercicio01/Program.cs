using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, soma = 0;
            Console.WriteLine("\nExercício 01 - Soma de números indeterminados");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Digite um valor: (zero para encerrar)");
            n1 = double.Parse(Console.ReadLine());
            while (n1 != 0) {
                soma += n1;
                Console.WriteLine("Digite um valor: (zero para encerrar)");
                n1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma dos valores lidos é : {0}", soma);
        }
    }
}
