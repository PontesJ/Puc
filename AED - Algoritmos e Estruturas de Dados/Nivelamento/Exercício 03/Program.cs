using System;

namespace Exercício_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            Console.WriteLine("Exercício 03");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Insira uma idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade > 18) soma++;
            }
            Console.WriteLine("{0} pessoas possuem mais de 18 anos", soma);
        }
    }
}
