using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, comprimento, area, volume;
            Console.WriteLine("\nExercício 07 - Circuferência");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digite o raio de um esfera:");
            raio = double.Parse(Console.ReadLine());
            comprimento = 2 * Math.PI * raio;
            area = Math.Pow(Math.PI * raio, 2);
            volume = Math.Pow(4 / 3 * Math.PI, 3);
            Console.WriteLine("O comprimento dessa esfera é: " + comprimento);
            Console.WriteLine("A área dessa esfera é: " + area);
            Console.WriteLine("O volume dessa esfera é: "+ volume); 
        }
    }
}
