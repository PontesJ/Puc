using System;

namespace Questão_02
{
    class Program
    {
        static int funcRec1(int a){
            if (a<=1)
                return 0;
            else
                return funcRec1((a-2) + 5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("Questão 02");
            Console.Write("\nDigite um número: ");
            int a = int.Parse(Console.ReadLine());
            funcRec1(a);
            Console.WriteLine("\nFim");
            Console.WriteLine("================================\n");
        }
    }
}
