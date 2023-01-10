using System;

namespace Exercício_02
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

        static void imprime(int[] vetor, int quant)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("A fila: ");
            for (int i = 0; i < quant; i++)
                Console.Write(vetor[i] + " ");

            Console.WriteLine();
            Console.ResetColor();
        }
        static void imprime2(int[] vetor, int quant)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Fila Inversa: ");
            for (int i = 0; i < quant; i++)
                Console.Write(vetor[i] + " ");

            Console.WriteLine();
            Console.ResetColor();
        }
        static int[] inverte(int[] vetor, int quant)
        {
            int[] pilha = new int[quant];
            int[] aux = new int[quant];
            int n = quant;

            for (int i = 0; i < quant;)
                adicionar(pilha, ref i, remover(vetor, ref n));

            for (int i = 0; i < quant;)
                adicionar(vetor, ref i, pilha[i]);

            n = quant;

            for (int i = 0; i < quant;)
                adicionar(aux, ref i, removerPilha(pilha, ref n));

            return aux;
        }
        static int removerPilha(int[] pilha, ref int quant)
        {
            quant--;
            return pilha[quant];
        }
        static void Main(string[] args)
        {
            int[] fila = new int[10] { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            int quant = 5;

            int[] aux = new int[quant];
            aux = inverte(fila, quant);
            
            imprime(fila, quant);
            imprime2(aux, quant);
        }
    }
}
