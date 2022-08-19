using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double temp;
            Console.WriteLine("\nExercício 01 - °C para °F");
            Console.WriteLine("-------------------------");
            Console.WriteLine("°C \t °F");
            for (i = 0; i <= 100; i++) {
                temp = 9.0 * i / 5.0 + 32.0;
                Console.WriteLine("{0} \t {1}", i, temp);
            }
        }
    }
}
