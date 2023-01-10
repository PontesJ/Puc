using System;

namespace Exercício_02
{
    class Program
    {
        static void inserir(int[] vetor, int num, int pos, int ultimo)
        {
            int j = ultimo;
            for (int i = ultimo; i != pos; i--)
            {
                if (i < 0)
                {
                    i = tam;
                    if (i == pos) break;
                }
                vetor[i] = vetor[i - 1];
            }
            vetor[pos] = num;
        }
        static void remover(int[] vetor, ref int primeiro, ref int ultimo, int num)
        {
            int pos = posicao(vetor, primeiro, ultimo, num);
            if (pos == -1)
            {
                Console.WriteLine("O número {0}, não está presente na lista", num);
            }
            else
            {
                Console.WriteLine("O número {0} foi removido", vetor[pos]);
                if (pos == primeiro)
                {
                    primeiro ++;
                }
                else if (pos == ultimo)
                {
                    ultimo--;
                    if (ultimo == -1)
                    {
                        ultimo = tam - 1;
                    }
                }
                else
                {
                    for (int i = pos; i != ultimo; i++)
                    {
                        if (i > tam - 1)
                        {
                            i = 0;
                        }
                        if ((i + 1) > tam - 1)
                        {
                            vetor[i] = vetor[0];
                        }
                        else
                        {
                            vetor[i] = vetor[i + 1];
                        }
                    }
                    ultimo--;
                }
            }
        }
        static int posicao(int[] vetor, int primeiro, int ultimo, int num)
        {
            int valid = 0, pos = 0;
            if (primeiro == ultimo)
            {
                if (primeiro >= tam)
                {
                    primeiro = 0;
                }
                if (vetor[primeiro] == num)
                {
                    valid++;
                    pos = primeiro;
                }
                for(int i = primeiro + 1; i != ultimo; i++)
                {
                    if (i >= tam)
                    {
                        i = 0;
                    }
                    if (vetor[i] == num)
                    {
                        valid++;
                        pos = i;
                        break;
                    }
                }
            }
            else
            {
                for(int i = primeiro; i != ultimo; i++)
                {
                    if (i >= tam)
                    {
                        i = 0;
                    }
                    if (vetor[i] == num)
                    {
                        valid++;
                        pos = i;
                        break;
                    }
                }
            }
            
            if (valid >= 1)
            {
                return pos;
            }
            else
            {
                return -1;
            }
        }
        static void imprimir(int[] vetor, int primeiro, int ultimo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Lista: ");
            Console.ResetColor();
            if (primeiro == ultimo)
            {
                Console.Write("{0} ", vetor[primeiro]);
                for (int i = primeiro + 1; i != ultimo; i++)
                {
                    if (i > tam - 1)
                    {
                        i = 0;
                        if (i == ultimo) break;
                    }
                    Console.Write("{0} ", vetor[i]);
                }
            }
            else
            {
                for (int i = primeiro; i != ultimo; i++)
                {
                    if (i > tam - 1)
                    {
                        i = 0;
                        if (i == ultimo) break;
                    }
                    Console.Write("{0} ", vetor[i]);
                }
            }
        }
        const int tam = 5;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Lista Circular Estática");
            int[] lista = new int [tam];
            int primeiro = 0, ultimo = 0, remov = 0, quant = 0;
            do
            {
                Console.Write("\nInserir [1] / Remover [2] / Sair [3]: ");
                remov = int.Parse(Console.ReadLine());
                if (remov == 1)
                {
                    if (quant == tam)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Lista Cheia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Insira o número a ser armazenado: ");
                        Console.ResetColor();
                        int num = int.Parse(Console.ReadLine());
                        if (ultimo == tam)
                        {
                            ultimo = 0;
                        }
                        Console.Write("Deseja inserir em uma posição especifica? [1 = Sim] / [2 = Não]: ");
                        int valid = int.Parse(Console.ReadLine());
                        if (valid == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Digite a posição desejada: ");
                            Console.ResetColor();
                            int pos = int.Parse(Console.ReadLine());
                            pos--;
                            inserir(lista, num, pos, ultimo);
                            ultimo++;
                            quant++;
                        }
                        else if (valid == 2)
                        {
                            lista[ultimo] = num;
                            ultimo++;
                            quant++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Digite um valor válido");
                            Console.ResetColor();
                        }
                        if (ultimo > tam)
                        {
                            ultimo %= tam;
                        }
                        imprimir(lista, primeiro, ultimo);
                        
                    }
                }
                else if (remov == 2)
                {
                    if (primeiro == ultimo && quant == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Lista Vazia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Insira o número a ser removido: ");
                        Console.ResetColor();
                        int r = int.Parse(Console.ReadLine());
                        remover(lista, ref primeiro, ref ultimo, r);
                        imprimir(lista, primeiro, ultimo);
                        quant--;
                    }
                }
                else if (remov == 4)
                {
                    for (int i = 0; i < lista.Length; i++)
                    {
                        Console.Write("{0} ", lista[i]);
                    }
                }
                else if (remov != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite um valor valido!");
                    Console.ResetColor();
                }
            }
            while (remov != 3);
            imprimir(lista, primeiro, ultimo);
            Console.WriteLine("\n================================\n");
        }
    }
}