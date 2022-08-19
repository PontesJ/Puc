using System;

namespace exercicio06c
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, num, soma = 0;
            Console.WriteLine("\nExercício 06 - C");
            Console.WriteLine("----------------");
            Console.WriteLine("Digite um número:");
            num = double.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++) {
                if (i % 2 != 0) {
                    soma += i / (i * i);
                } else soma -= i / (i * i);
            }
            Console.WriteLine("L = {0}", soma);
        }
    }
}
