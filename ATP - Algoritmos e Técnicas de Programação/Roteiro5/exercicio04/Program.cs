using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, div;
            Console.WriteLine("\nExercício 04 - Divisores");
            Console.WriteLine("------------------------");
            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());
            div = n1;
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Os divisores de {0} são:", n1);
            while (div >= 1) {
                if (n1 % div == 0) Console.WriteLine(div);
                div --;
            }
        }
    }
}
