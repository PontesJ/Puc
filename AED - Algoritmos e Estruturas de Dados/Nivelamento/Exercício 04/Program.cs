using System;

namespace Exercício_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxmatricula = 0, minmatricula = 0;
            double maxaltura = 0, minaltura = 3.0;
            Console.WriteLine("Exercício 04");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Insira sua altura (m): ");
                double altura = double.Parse(Console.ReadLine());
                Console.Write("Insira sua matricula: ");
                int matricula = int.Parse(Console.ReadLine());
                if (altura > maxaltura)
                {
                    maxaltura = altura;
                    maxmatricula = matricula;
                }
                if (altura < minaltura)
                {
                    minaltura = altura;
                    minmatricula = matricula;
                }
            }
            Console.WriteLine("A matricula do aluno mais alto é " + maxmatricula);
            Console.WriteLine("A matricula do aluno mais baixo é " + minmatricula);
        }
    }
}
