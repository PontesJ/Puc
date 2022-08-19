using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, subtração;
            Console.WriteLine("\nExercício 01 - Subtração de dois números");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Digite o primeiro número:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            numero2 = int.Parse(Console.ReadLine());
            subtração = numero1 - numero2;
            Console.WriteLine("A subtração desses dois números é: " + subtração);
            Console.ReadKey();
        }
    }
}
