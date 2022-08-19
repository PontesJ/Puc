using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("\nExercício 03 - Múltiplos de 3 no intervalo");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Digite o primeiro valor:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (n1 > n2) {
                while (n2 % 3 != 0) n2 ++;
                while (n2 <= n1) {
                    Console.Write("{0}\t", n2);
                    n2 += 3;
                }
            } else if (n2 > n1) {
                while (n1 % 3 != 0) n1 ++;
                while (n1 <= n2) {
                    Console.Write("{0}\t", n1);
                    n1 += 3;
                }
            } else Console.WriteLine("Os números são iguais");
        }
    }
}
