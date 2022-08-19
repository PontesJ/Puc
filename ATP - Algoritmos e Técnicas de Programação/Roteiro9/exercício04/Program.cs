using System;

namespace exercício04
{
    class Program
    {
        static void LerChar (char []vetor) {
            Console.Write("Digite uma frase de 120 caracteres: ");
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = (char)Console.Read();
            }
        }
        
        static int VezesBranco (char []vetor) {
            int branco = 0;
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] == ' ') branco++;
            }
            return branco;
        }

        static int VezesP (char []vetor) {
            int p = 0;
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] == 'P' || vetor[i] == 'p') p++;
            }
            return p;
        }

        static int LetraFinder (char []vetor, char letra) {
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] == letra) {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int local;
            char letra;
            char []frase = new char[120];
            Console.WriteLine("\nExercício 04 - Frase");
            Console.WriteLine("--------------------");
            LerChar(frase);
            Console.WriteLine("--------------------");
            Console.WriteLine("Existe {0} brancos na frase", VezesBranco(frase));
            Console.WriteLine("Existe {0} 'P' na frase", VezesP(frase));
            Console.WriteLine("--------------------");
            Console.Write("Digite a letra que deseja procurar: ");
            letra = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            local = LetraFinder(frase, letra);
            if (local != -1) Console.WriteLine("A letra {0} aparece na posição {1}", letra, local + 1);
            else Console.WriteLine("A letra {0} não aparece no texto", letra);
        }
    }
}
