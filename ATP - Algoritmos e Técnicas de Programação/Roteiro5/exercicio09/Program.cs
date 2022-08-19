using System;

namespace exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int po;
            double n1 = 0, n2 = 1, soma = 0, cont = 1; // Está em double por conta do alto uso de memoria
            Console.WriteLine("\nExercício 09 - N-ésimo termo de Fibonacci");
            Console.WriteLine("-----------------------------------------");
            do {
                Console.WriteLine("\nDigite a posição do número que quer descobrir na sequência de Fibonacci:");
                po = int.Parse(Console.ReadLine());
            } while (po <= 0);
            n1 = 0; n2 = 1; soma = 0; cont = 1;
            while (cont < po) {
                soma = n1 + n2;
                n1 = n2;
                n2 = soma;
                cont++;
                if (soma == 1) Console.Write("\n1\t");
                Console.Write("{0}\t", soma);
            }
        }
    }
}
