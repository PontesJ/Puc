using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Cont, Fat;
            char repetir;
            do {
                Console.WriteLine("EXEMPLO PARA CALCULAR FATORIAL DE N");
                Console.WriteLine("Entre com um valor para cálculo do fatorial: ");
                N = int.Parse(Console.ReadLine());
                Fat = N;
                if (N >= 0) {
                    Cont = N;
                    while (Cont > 1) {
                        N = N * (Cont - 1);
                        Cont--;
                    }
                    Console.WriteLine("O fatorial de {0} é {1}", Fat, N);
                } else Console.WriteLine("Não posso calcular fatorial de número negativo");
                Console.WriteLine("\n Deseja repetir o programa ? (S / N)");
                repetir = Console.ReadKey().KeyChar;
            } while (repetir == 'S' || repetir == 's');
        }
    }
}
