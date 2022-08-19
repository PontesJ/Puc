using System;

namespace exercicio03
{
    class Program
    {
        static void LeVetor( double []vetor) {
            for (int i = 0; i < vetor.Length; i++ ) {
                do {
                    Console.Write("Entre com o dia {0}: ", i+1);
                    vetor[ i ] = double.Parse(Console.ReadLine());
                } while (vetor[i] < 15 || vetor[i] > 40 );
            }
        }

        static void MenorEMaior (double []vetor, ref double menor, ref double maior) {
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] > maior) maior = vetor[i];
                if (vetor[i] < menor) menor = vetor[i];
            }
        }

        static double Media (double []vetor) {
            double soma = 0;
            for (int i = 0; i < vetor.Length; i++) {
                soma += vetor[i];
            }
            return soma/vetor.Length;
        }

        static void MenorMedia (double []temp, double []inf, double media) {
            int j = 0;
            for (int i = 0; i < temp.Length; i++) {
                if (temp[i] < media) {
                    inf[j] = i + 1;
                    j++;
                } 
            }
        }

        static void Main(string[] args)
        {
            double media, maior = 0, menor = 45;
            double []temp = new double[10];
            double []inf = new double[10];
            Console.WriteLine("\nExercício 03 - Temperatura");
            Console.WriteLine("--------------------------");
            LeVetor(temp);
            MenorEMaior(temp, ref menor, ref maior);
            media = Media(temp);
            MenorMedia(temp, inf, media);
            Console.WriteLine("--------------------------");
            Console.WriteLine("A menor temperatura foi de {0}°", menor);
            Console.WriteLine("A maior temperatura foi de {0}°", maior);
            Console.WriteLine("A temperatura média foi de {0}°", media);
            Console.Write("Os dias que a temperatura foi menor que a média foram os dias: ");
            for (int i = 0; i < inf.Length; i++) {
                if (inf[i] != 0) Console.Write(inf[i] + " ");
            }
        }
    }
}
