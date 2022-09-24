using System;

namespace Exercício_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Exercício 02");
            Console.WriteLine("Qual questão quer? (1/2/3)");
            int quest = int.Parse(Console.ReadLine());
            if (quest == 1)
            {
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());
                int primo = 0;
                for (int k = num; k > 0; k--)
                {
                    if (num % k == 0) primo++;
                }
                if (primo == 2) Console.Write("O número {0} é Primo", num);
                else Console.Write("O número {0} NÃO é Primo", num);
                Console.WriteLine("\n================================\n");
            }
            else if (quest == 2)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Os números perfeitos de 1 até 1000 são:");
                for (int i = 1; i <= 1000; i++)
                {
                    int soma = 0;
                    for (int k = i; k > 0; k--) if (i % k == 0 && k != i) soma += k;
                    if (soma == i) Console.WriteLine(i);
                }
                Console.WriteLine("================================");
            }
            else if (quest == 3)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Os primos de 1 até 1000 são:");
                for (int i = 2; i <= 1000; i++)
                {
                    int primo = 0;
                    for (int k = i; k > 0; k--) if (i % k == 0) primo++;
                    if (primo == 2) Console.Write(i + ", ");
                }
                Console.WriteLine("\n================================");
            }
            else Console.WriteLine("Número Invalido");
        }
    }
}
