using System;

namespace Exercício_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 05");
            Console.Write("Digite a operação desejada (+|-|*|/): ");
            string operacao = Console.ReadLine();
            Console.Write("Insira o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            switch (operacao)
            {
                case "+":
                    Console.WriteLine("A soma desses valores é {0}", n1 + n2);
                    break;
                case "-":
                    Console.WriteLine("A subtração desses valores é {0}", n1 - n2);
                    break;
                case "*":
                    Console.WriteLine("A multiplicação desses valores é {0}", n1 * n2);
                    break;
                case "/":
                    Console.WriteLine("A divisão desses valores é {0}", n1 / n2);
                    break;
                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }
        }
    }
}
