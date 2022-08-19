using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, sinal, operacao;
            Console.WriteLine("\nExercício 01 - Operações Básicas");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o primeiro número:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número correspondente a operação (+ = 1, - = 2, * = 3, / = 4):");
            sinal = float.Parse(Console.ReadLine());
            if (sinal == 1) {
                operacao = n1 + n2;
                Console.WriteLine("A soma entre {0} e {1} é {2}", n1, n2, operacao);
            } else {
                if (sinal == 2) {
                    operacao = n1 - n2;
                    Console.WriteLine("A subtração entre {0} e {1} é {2}", n1, n2, operacao);
                } else {
                    if (sinal == 3) {
                        operacao = n1 * n2;
                        Console.WriteLine("A multiplicação entre {0} e {1} é {2}", n1, n2, operacao);
                     } else {
                        if (sinal == 4) {
                            operacao = n1 / n2;
                            Console.WriteLine("A divisão entre {0} e {1} é {2}", n1, n2, operacao);
                        } else {
                            Console.WriteLine("Digite um valor valido");
                        }
                    }
                }
            }
        }
    }
}
