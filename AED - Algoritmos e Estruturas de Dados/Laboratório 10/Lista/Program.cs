using System;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Lista");
            Listas lista = new Listas();
            int valid;
            do
            {
                Console.Write("Inserir [1] / Remover [2] / Sair [3]: ");
                valid = int.Parse(Console.ReadLine());
                if (valid == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Digite algo: ");
                    Console.ResetColor();
                    string num = Console.ReadLine();
                    Console.Write("Deseja adicionar em uma posição especifica? [1 = Sim / 2 = Não] ");
                    int val = int.Parse(Console.ReadLine());
                    if (val == 1)
                    {
                        Console.Write("Em qual posição deseja adicionar? ");
                        lista.adicionar(num, int.Parse(Console.ReadLine()));
                    } 
                    else if (val == 2)
                    {
                        lista.adicionar(num);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Valor invalido");
                        Console.ResetColor();
                    }
                    lista.imprimi();
                }
                else if (valid == 2)
                {
                    int validar = lista.remover();
                    if (validar == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Lista Vazia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("Qual elemento deseja remover? ");
                        string n = lista.remover(Console.ReadLine());
                        if (n != "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O elemento '{0}' foi removido", n);
                            Console.ResetColor();
                        }
                        lista.imprimi();
                    }
                }
                else if (valid != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite um valor valido!");
                    Console.ResetColor();
                }
            } while (valid != 3);

            lista.imprimi();
            Console.WriteLine("================================\n");
        }
    }
}
