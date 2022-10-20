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
        static void Main(string[] args)
        {
            string[] cpfS = new string [10];
            for (int i = 0; i < cpfS.Length; i++) cpfS[i] = criarCPF();
            for (int i = 0; i < cpfS.Length; i++) Console.WriteLine(cpfS[i]);
        }
    }
}
