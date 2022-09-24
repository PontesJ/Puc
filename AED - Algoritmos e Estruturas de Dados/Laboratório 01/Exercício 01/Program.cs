using System;

namespace Exercício_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExercício 01");
            Console.WriteLine("====");
            for (int i = 1000; i <= 9999; i++)
            {
                int Primeiro = Convert.ToInt32(i.ToString().Substring(0, 2));
                int Ultimo = ((Primeiro * 100) - i) * -1;
                if (Math.Pow((Primeiro + Ultimo), 2) == i) Console.WriteLine(i);
            }
            Console.WriteLine("====");
        }
    }
}