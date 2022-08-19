using System;

namespace exercício02
{
    class Program
    {
        static void LeVetor( float []vetor) {
            for (int i = 0; i < vetor.Length; i++ ) {
                Console.Write("Entre com o {0} número: ", i+1);
                vetor[ i ] = float.Parse(Console.ReadLine());
            }
        }
        
        static void comp (float []vetor, ref int posi, ref int nega, float []pos, float []neg) {
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] >= 0) {
                    pos[posi] = vetor[i];
                    posi++;
                } else {
                    neg[nega] = vetor[i];
                    nega++;
                }
            }
        }

        static void Main(string[] args)
        {
            int posi = 0, nega = 0;
            Console.WriteLine("\nExercício 02 - Números Positivos e Negativos");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Digite a quantidade de número no conjunto: ");
            int t = int.Parse(Console.ReadLine());
            float []num = new float[t];
            float []pos = new float[t];
            float []neg = new float[t];
            LeVetor(num);
            comp(num, ref posi, ref nega, pos, neg);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Números positivos: {0}", posi);
            Console.Write("São eles: ");
            for (int i = 0; i < posi; i++) Console.Write(pos[i] + " ");
            Console.Write("\n");
            Console.WriteLine("Números negativos: {0}", nega);
            Console.Write("São eles: ");
            for (int i = 0; i <= nega; i++) Console.Write(neg[i] + " ");
        }
    }
}
