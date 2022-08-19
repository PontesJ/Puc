using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double basemaior, basemenor, altura, area;
            Console.WriteLine("\nExercício 04 - Área de um Trapézio");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Digite a base maior:");
            basemaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base menor:");
            basemenor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            altura = double.Parse(Console.ReadLine());
            area = (basemaior + basemenor) * altura / 2;
            Console.WriteLine("A área desse trapézio é: " + area);
            Console.ReadKey();
        }
    }
}
