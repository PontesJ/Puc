using System;

namespace Pilha
{
    class Program
    {
        static void adicionar(int[] pilha, ref int quant, int n)
        {
            pilha[quant] = n;
            quant++;
        }
        static int remover(int[] pilha, ref int quant)
        {
            quant--;
            return pilha[quant];
        }
        static char validar(char c, int n)
        {
            Console.WriteLine();
            if (n == 1)
            {
                while (c != 'S' && c != 's' && c != 'n' && c != 'N')
                {
                    Console.Write("Digite valores validos (s/n): ");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                return c;
            }
            else
            {
                while (c != 'a' && c != 'A' && c != 'r' && c != 'R')
                {
                    Console.Write("Digite um valor valido (a/r): ");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                return c;
            }
        }
        static void imprime(int[] vetor, int quant)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A pilha: ");

            for (int i = 0; i < quant; i++)
                Console.Write(vetor[i] + " ");

            Console.WriteLine();
            Console.ResetColor();
        }
        const int tam = 10;
        static void Main(string[] args)
        {
            char repetir;
            int[] pilha = new int[tam] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            int quant = 5;
            imprime(pilha, quant);

            do
            {
                Console.Write("Deseja adicionar ou remover um número (a/r): ");
                char valid = Console.ReadKey().KeyChar;
                valid = validar(valid, 2);

                if (valid == 'a' || valid == 'A')
                {
                    if (quant >= tam)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Pilha Cheia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Digite um número para adicionar na pilha: ");
                        Console.ResetColor();

                        adicionar(pilha, ref quant, int.Parse(Console.ReadLine()));
                        imprime(pilha, quant);
                    }
                }
                else
                {
                    if (quant <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Pilha Vazia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O número {0} foi removido", remover(pilha, ref quant));
                        Console.ResetColor();

                        imprime(pilha, quant);
                    }
                }
                Console.Write("Deseja continuar? (s/n) ");
                repetir = Console.ReadKey().KeyChar;
                repetir = validar(repetir, 1);

            } while (repetir == 'S' || repetir == 's');
            
            imprime(pilha, quant);
        }
    }
}
