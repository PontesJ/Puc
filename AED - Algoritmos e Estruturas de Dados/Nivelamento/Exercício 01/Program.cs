using System;

namespace Exercício_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            Console.WriteLine("Exercício 01");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe a idade do {0}° aluno: ", i + 1);
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A média da idade dos 5 alunos é de {0} anos", soma / 5);
        }
    }
}
