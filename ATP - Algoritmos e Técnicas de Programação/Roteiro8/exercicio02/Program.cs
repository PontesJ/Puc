using System;

namespace exercicio02
{
    class Program
    {
        static int numero_primo (int n) {
            int numero, primo = 0;
            numero = n;
            for ( ; 1 <= numero; numero--) {
                if (n % numero == 0) primo ++;
            }
            if (primo > 2) {
                return 0;
            } else {
                return 1;
            }
        }        
        /*static void Main(String[] args) {
            int n, a;
            n = int.Parse(Console.ReadLine());
            a = numero_primo(n);
            Console.WriteLine(a);
        } */
    }
}
