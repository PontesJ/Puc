using System;

namespace exercicio01
{
    class Program
    {
        static int le_no_intervalo(int n) {
            if (n % 2 != 0) {
                do {
                    n = int.Parse(Console.ReadLine());
                } while (n >= 32 || n <= 0);
            } else {
                do {
                    n = int.Parse(Console.ReadLine());
                } while (n >= 13 || n <= 0);
            }
            return n;
        }
        static void Main(string[] args) {
            int dia, mes;
            Console.WriteLine("Informe o dia entre 1 e 31: ");
            dia = le_no_intervalo(1);
            Console.WriteLine("Informe o mes entre 1 e 12: ");
            mes = le_no_intervalo(2);
            Console.WriteLine("Data: {0}/{1}", dia, mes);
        }
    }
}
