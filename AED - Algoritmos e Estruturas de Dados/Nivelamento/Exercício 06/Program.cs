using System;

namespace Exercício_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 06");
            Console.Write("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permissão");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida");
                Console.ResetColor();
            }
        }
    }
}
