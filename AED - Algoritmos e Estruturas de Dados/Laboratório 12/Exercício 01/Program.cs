using System;

namespace Exercício_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("Árvore ABB");
            ArvoreBinaria Arvore = new ArvoreBinaria();
            int valid;
            do
            {
                Console.Write("\nInserir [1] / Remover [2] / Procurar Valor [3] / Em Ordem [4] / Pré-Ordem [5] / Pós-Ordem [6] / Sair [7]: ");
                valid = int.Parse(Console.ReadLine());
                if (valid == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nDigite o número a ser inserido na árvore: ");
                    Console.ResetColor();
                    Arvore.inserir(int.Parse(Console.ReadLine()));
                }
                else if (valid == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nDigite o número a ser removido da árvore: ");
                    Console.ResetColor();
                    Arvore.remover(int.Parse(Console.ReadLine()));
                }
                else if (valid == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nDigite o número a ser procurado na árvore: ");
                    Console.ResetColor();
                    int num = int.Parse(Console.ReadLine());
                    bool existe = Arvore.pesquisa(num);
                    if (existe)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nO número {0} está presente na árvore", num);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nO número {0} não está presente na árvore", num);
                        Console.ResetColor();
                    }
                }
                else if (valid == 4)
                {
                    Arvore.emOrdem();
                }
                else if (valid == 5)
                {
                    Arvore.preOrdem();
                }
                else if (valid == 6)
                {
                    Arvore.posOrdem();
                }
                else if (valid != 7)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nDigite um valor válido");
                    Console.ResetColor();
                }
            }
            while (valid != 7);
            Console.WriteLine("\n===========================================================================================================\n");
        }
    }
}
