using System;
using System.IO;

namespace exercicio06
{
    class Program
    {
        const int TAM = 256;
        static void Main(string[] args) {
            double soma = 0;
            string linha, texto = "";
            char letra;
            int []letras = new int [TAM]; 
            StreamReader ler = new StreamReader("C:\\Users\\joaog\\Documents\\Puc\\Lab\\Roteiro11\\textos\\texto.txt");
            linha = ler.ReadLine();
            while (linha != null) {
                texto += linha;
                texto = texto.ToUpper();
                for (int i = 0; i < TAM; i++) letras[i] = 0;
                for (int i = 0; i < texto.Length; i++) letras[texto[i]]++;
                linha = ler.ReadLine();
            }
            for (letra = (char)65; letra < TAM; letra++) {
                if (letras[letra] != 0 && letra >= 65 && letra <= 90) {
                    soma += letras[letra];
                }
            }
            for (letra = (char)65; letra < TAM; letra++) {
                if (letra >= 65 && letra <= 90) {
                    Console.WriteLine("{0} = {1:0.00}%", letra, ((letras[letra] / soma) * 100));
                }
            }
            ler.Close();
        }
    }
}
