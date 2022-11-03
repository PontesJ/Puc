using System;

namespace Lista
{
    class Program
    {
        static void adicionar(int[] lista, int flag, ref int quant, int n)
        {
            if (flag > quant)
            {
                flag = quant;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Existem espaços livres, posição redefinida para {0}°", flag + 1);
                Console.ResetColor();
            }
            else if (flag < quant)
                for (int i = quant; i > flag; i--)
                    lista[i] = lista[i - 1];

            lista[flag] = n;
            quant++;
        }
        static int remover(int[] lista, int pos, ref int quant)
        {
            int n = lista[pos];
            for (int i = pos; i < quant - 1; i++)
                lista[i] = lista[i + 1];
            quant--;
            return n;
        }
        static int procurar(int[] vetor, int tam, int numero)
        {
            for (int i = 0; i < tam; i++)
                if (vetor[i] == numero)
                    return i;
            return -1;
        }
        static char validar(char c, int n)
        {
            Console.WriteLine();
            if (n == 1 || n == 3)
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
            Console.Write("A lista: ");
            for (int i = 0; i < quant; i++)
                Console.Write(vetor[i] + " ");
            Console.WriteLine();
            Console.ResetColor();
        }
        const int tam = 10;
        static void Main(string[] args)
        {
            char repetir;
            int[] lista = new int[tam] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            int quant = 5;
            imprime(lista, quant);
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
                        Console.WriteLine("Lista Cheia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Digite um número para adicionar na lista: ");
                        Console.ResetColor();
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("Deseja adicionar em uma determinada posição? (s/n): ");
                        char valida = Console.ReadKey().KeyChar;
                        valida = validar(valida, 3);
                        int flag = quant;
                        if (valida == 's' || valida == 'S')
                        {
                            Console.Write("Digite a posição que deseja inserir o número: ");
                            flag = int.Parse(Console.ReadLine());
                            while (flag > lista.Length - 1 || flag < 0)
                            {
                                Console.Write("Digite uma posição valida: ");
                                flag = int.Parse(Console.ReadLine());
                            }
                            flag--;
                        }
                        adicionar(lista, flag, ref quant, n);
                        imprime(lista, quant);
                    }
                }
                else
                {
                    if (quant <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Lista Vazia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("Qual número deseja remover: ");
                        int n = int.Parse(Console.ReadLine());
                        int num = procurar(lista, quant, n);
                        if (num == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("O número {0} não está presente na lista", n);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O número {0} foi removido", remover(lista, num, ref quant));
                            Console.ResetColor();
                            imprime(lista, quant);
                        }
                    }
                }
                Console.Write("Deseja continuar? (s/n) ");
                repetir = Console.ReadKey().KeyChar;
                repetir = validar(repetir, 1);
            } while (repetir == 'S' || repetir == 's');
            imprime(lista, quant);
        }
    }
}
