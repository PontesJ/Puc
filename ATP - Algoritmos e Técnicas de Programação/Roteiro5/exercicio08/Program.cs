using System;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, soma = 0, i = 0;
            Console.WriteLine("\nExercício 08 - BlackJack");
            Console.WriteLine("------------------------");
            while (soma < 21) {
                do {
                    Console.WriteLine("Digite um número positivo menor que 13:");
                    n1 = int.Parse(Console.ReadLine());
                } while (n1 > 13 || n1 < 1);
                soma += n1;
                i++;
                if (soma < 21) {
                    Console.WriteLine("Já foram lidos {0} número(s), Ainda não acabou", i);
                    Console.WriteLine("");
                }
            }
            if (soma == 21) Console.WriteLine("Acabado, soma = 21 – você ganhou.");
            else Console.WriteLine("Acabou – você perdeu");
        }
    }
}
