using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double seno, cosseno;
            Console.WriteLine("\nExercício 03 - Tabela Seno e Cosseno");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ângulo \t Seno \t Cosseno");
            for (i = 0; i <= 360; i += 15) {
                seno =  Math.Sin(i * (Math.PI / 180));
                cosseno =  Math.Cos(i * (Math.PI / 180));
                Console.WriteLine("{0} \t {1:0.0000} \t {2:0.0000}", i, seno, cosseno);
            }
        }
    }
}
