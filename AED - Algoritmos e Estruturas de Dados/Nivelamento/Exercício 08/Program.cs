using System;

namespace Exercício_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 08");
            Console.Write("Digite seu salário: ");
            int salario = int.Parse(Console.ReadLine());
            if (salario < 1700) salario += 300;
            else salario += 200;
            Console.WriteLine("O novo salário é de {0}", salario);
        }
    }
}
