using System;

namespace Fila
{
    class Program
    {
        static void adicionar(int[] fila, ref int quant, int n)
        {
            fila[quant] = n;
            quant++;
        }
        static int remover(int[] fila, ref int quant)
        {
            int n = fila[0];
            for (int i = 0; i < quant - 1; i++)
                fila[i] = fila[i + 1];
            quant--;
            return n;
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
            Console.Write("A fila: ");
            for (int i = 0; i < quant; i++)
                Console.Write(vetor[i] + " ");
            Console.WriteLine();
            Console.ResetColor();
        }
        const int tam = 10;
        static void Main(string[] args)
        {
            char repetir;
            int[] fila = new int[tam] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            int quant = 5;
            imprime(fila, quant);
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
                        Console.WriteLine("Fila Cheia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Digite um número para adicionar na fila: ");
                        Console.ResetColor();
                        adicionar(fila, ref quant, int.Parse(Console.ReadLine()));
                        imprime(fila, quant);
                    }
                }
                else
                {
                    if (quant <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Fila Vazia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O número {0} foi removido", remover(fila, ref quant));
                        Console.ResetColor();
                        imprime(fila, quant);
                    }
                }
                Console.Write("Deseja continuar? (s/n) ");
                repetir = Console.ReadKey().KeyChar;
                repetir = validar(repetir, 1);
            } while (repetir == 'S' || repetir == 's');
            imprime(fila, quant);
        }
    }
}
