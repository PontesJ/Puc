using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double antigo, novo, desconto;
            Console.WriteLine("\nExercício 03 - Desconto de 10%");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o valor do produto:");
            antigo = double.Parse(Console.ReadLine());
            desconto = antigo * 0.1;
            novo = antigo - desconto;
            Console.WriteLine("\nO novo preço do produto será R$" + novo);
            Console.ReadKey();
        }
    }
}
