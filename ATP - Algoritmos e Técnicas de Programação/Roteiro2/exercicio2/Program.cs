using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media;
            Console.WriteLine("\nExercício 02 - Média Ponderada");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite a nota com 2 de peso:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota com 3 de peso:");
            nota2 = float.Parse(Console.ReadLine());
            media = ((nota1 * 2) + (nota2 * 3)) / 5;
            Console.WriteLine("A sua média é: " + media);
            Console.ReadKey();
        }
    }
}
