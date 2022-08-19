using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double temp;
            Console.WriteLine("\nExercício 04 - °C para °K");
            Console.WriteLine("-------------------------");
            Console.WriteLine("°C \t °K");
            for (i = 0; i <= 100; i++) {
                temp = i + 273.15;
                Console.WriteLine("{0} \t {1}", i, temp);
            }
        }
    }
}
