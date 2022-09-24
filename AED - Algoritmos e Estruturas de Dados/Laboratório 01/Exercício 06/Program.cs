using System;

namespace Exercício_06
{
    class Program
    {
        static void expo(ref int x, ref int y)
        {
            int aux = 1;
            for (int i = 0; i < y; i++) aux *= x;
            x = aux;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 06");
            Console.Write("\nInsira o número da base: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insira o número do expoente: ");
            int y = int.Parse(Console.ReadLine());
            expo(ref x, ref y);
            Console.WriteLine("\nO resultado dessa operação é: {0}", x);
            Console.WriteLine("================================\n");
        }
    }
}