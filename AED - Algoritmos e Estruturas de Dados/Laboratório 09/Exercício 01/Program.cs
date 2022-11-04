using System;

namespace Exercício_01
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

        static void imprime(int[] vetor, int quant)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("A pilha: ");
            for (int i = 0; i < quant; i++)
                Console.Write(vetor[i] + " ");

            Console.WriteLine();
            Console.ResetColor();
        }
        static int[] copiar(int[] vetor, int quant)
        {
            int[] aux = new int[quant];
            int[] aux2 = new int[quant];
            int n = quant;

            for (int i = 0; i < quant;)
                adicionar(aux, ref i, remover(vetor, ref n));

            n = quant;

            for (int i = 0; i < quant;)
                adicionar(aux2, ref i, remover(aux, ref n));

            return aux2;
        }
        static void Main(string[] args)
        {
            int[] pilha = new int[10] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            int quant = 5;

            int[] aux = new int[quant];
            aux = copiar(pilha, quant);
            
            imprime(pilha, quant);
            imprime(aux, quant);
        }
    }
}
