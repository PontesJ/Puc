using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double pol;
            Console.WriteLine("\nExercício 05 - Centímetros para Polegadas");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("°Centímetros \t Polegadas");
            for (i = 0; i <= 100; i += 2) {
                pol = i / 2.5;
                Console.WriteLine("{0} \t {1}", i, pol);
            }
        }
    }
}
