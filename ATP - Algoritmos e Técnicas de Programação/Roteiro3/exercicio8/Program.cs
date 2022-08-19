using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media;
            Console.WriteLine("\nExercício 08 - Notas e Média");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Informe a Primeira Nota:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Segunda Nota:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Terceira Nota:");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Quarta Nota:");
            n4 = float.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            if (n1 < 0 || n2 < 0 || n3 < 0 || n4 < 0 || n1 > 100 || n2 > 100 || n3 > 100 || n4 > 100) {
                Console.WriteLine("Por favor, digite valores validos");
            } else {
                if (media >= 60) {
                Console.WriteLine("Você foi aprovado com {0} de média", media);
            } else {
                Console.WriteLine("Você foi não foi aprovado, sua média foi de {0}", media);
            }
            }
        }
    }
}
