using System;

namespace Exercício_03
{
    class Program
    {
        static void adicionar(int[] lista, int flag, ref int quant, int n)
        {
            if (flag < quant)
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
        static int[] duplicar(int[] vetor, int quant, int quant2)
        {
            int[] aux = new int[quant];
            int[] aux2 = new int[quant2];
            int n = quant;

            for (int i = 0; i < quant;)
            {
                int m = n - 1;
                adicionar(aux, i, ref i, remover(vetor, m, ref n));
            }

            n = quant;

            for (int i = 0; i < quant;)
            {
                int m = n - 1;
                adicionar(aux2, i, ref i, remover(aux, m, ref n));
            }

            n = quant;

            for (int i = quant; i < quant2;)
            {
                int m = n - 1;
                adicionar(aux2, i, ref i, remover(vetor, m, ref n));
            }
            return aux2;
        }
        static void Main(string[] args)
        {
            int[] lista = new int[10] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            int quant = 5;

            int quant2 = 2 * quant;
            int[] aux = new int[quant2];
            aux = duplicar(lista, quant, quant2);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A lista: ");
            for (int i = 0; i < quant; i++)
                Console.Write(lista[i] + " ");
            Console.WriteLine();

            Console.Write("A lista 2x: ");
            for (int i = 0; i < quant2; i++)
                Console.Write(aux[i] + " ");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
