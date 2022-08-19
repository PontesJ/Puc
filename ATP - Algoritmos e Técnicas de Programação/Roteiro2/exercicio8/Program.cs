using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo1, angulo2, angulo3;
            Console.WriteLine("\nExercício 08 - Terceiro Ângulo de um Triângulo");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Digite o valor do primeiro ângulo:");
            angulo1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo ângulo:");
            angulo2 = double.Parse(Console.ReadLine());
            angulo3 = 180 - angulo1 - angulo2;
            Console.WriteLine("O valor do terceiro ângulo é: " + angulo3);
            Console.ReadKey();
        }
    }
}
