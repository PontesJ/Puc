using System;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Fila");
            Filas fila = new Filas();
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
                    fila.adicionar(Console.ReadLine());
                    fila.imprimi();
                }
                else if (valid == 2)
                {
                    string n = fila.remover();
                    if (n != "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O elemento '{0}' foi removido", n);
                        Console.ResetColor();
                        fila.imprimi();
                    }
                }
                else if (valid != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite um valor valido!");
                    Console.ResetColor();
                }
            } while (valid != 3);

            fila.imprimi();
            Console.WriteLine("================================\n");
        }
    }
}
