using System;

namespace Questão_04
{
    class Program
    {
        static string criarCPF()
        {
            Random rand = new Random();
            int[] vetor = new int[11] { rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), 0, 0 };
            int soma = 0, digito1, digito2;

            for (int i = 0, j = 10; i < vetor.Length - 2; i++, j--) soma += vetor[i] * j;

            int valid = soma % 11;

            if (valid <= 1) digito1 = 0;
            else digito1 = 11 - (valid);
            vetor[9] = digito1;

            soma = 0;
            for (int i = 1, j = 10; i < vetor.Length - 1; i++, j--) soma += vetor[i] * j;

            valid = soma % 11;

            if (valid <= 1) digito2 = 0;
            else digito2 = 11 - (valid);
            vetor[10] = digito2;

            string CPF = "";
            for (int i = 0; i < vetor.Length; i++) CPF += vetor[i];

            return CPF;
        }
        static void mergeSort(string[] vetor, int inicio, int tam)
        {
            if (inicio < tam)
            {
                int metade = inicio + (tam - inicio) / 2;
                mergeSort(vetor, inicio, metade);
                mergeSort(vetor, metade + 1, tam);
                merge(vetor, inicio, metade, tam);
            }
        }
        static void merge(string[] vetor, int inicio, int metade, int tam)
        {
            int i, j, k;
            int parte1 = metade - inicio + 1;
            int parte2 = tam - metade;
            string[] vetor1 = new string[parte1];
            string[] vetor2 = new string[parte2];
            for (i = 0; i < parte1; i++) vetor1[i] = vetor[inicio + i];
            for (j = 0; j < parte2; j++) vetor2[j] = vetor[metade + 1 + j];
            i = 0;
            j = 0;
            k = inicio;
            for (; i < parte1 && j < parte2; k++)
            {
                float n1 = float.Parse(vetor1[i]);
                float n2 = float.Parse(vetor2[j]);
                if (n1 <= n2)
                {
                    vetor[k] = vetor1[i];
                    i++;
                }
                else
                {
                    vetor[k] = vetor2[j];
                    j++;
                }
            }
            for (; i < parte1; i++, k++) vetor[k] = vetor1[i];
            for (; j < parte2; j++, k++) vetor[k] = vetor2[j];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n===========");
            Console.WriteLine("Questão 04");
            Console.WriteLine("\nOs Cpfs:\n");
            string[] cpfS = new string [50000];
            for (int i = 0; i < cpfS.Length; i++) cpfS[i] = criarCPF();
            for (int i = 0; i < cpfS.Length; i++) Console.WriteLine(cpfS[i]);
            mergeSort(cpfS, 0, cpfS.Length - 1);
            Console.WriteLine("\nOrdenados:\n");
            for (int i = 0; i < cpfS.Length; i++) Console.WriteLine(cpfS[i]);
            Console.WriteLine("===========\n");
        }
    }
}
