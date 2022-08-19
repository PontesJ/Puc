using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int postos = 0;
            double gasolina, diesel, alcool, MaiorG = 0, MaiorD = 0, MaiorA = 0, MenorG = 999, MenorD = 999, MenorA = 999;
            char rep;
            do {
                Console.WriteLine("\nExecício 05 - Postos de Combustíveis");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Fim do Programa quando Gasolina = 0");
                Console.WriteLine("Preço da Gasolina:");
                gasolina = double.Parse(Console.ReadLine());
                while (gasolina > 0) {
                    Console.WriteLine("Preço do Diesel:");
                    diesel = double.Parse(Console.ReadLine());
                    Console.WriteLine("Preço do Álcool:");
                    alcool = double.Parse(Console.ReadLine());
                    if (gasolina > MaiorG) MaiorG = gasolina;
                    if (diesel > MaiorD) MaiorD = diesel;
                    if (alcool > MaiorA) MaiorA = alcool;
                    if (gasolina < MenorG) MenorG = gasolina;
                    if (diesel < MenorD) MenorD = diesel;
                    if (alcool < MenorA) MenorA = alcool;
                    postos++;
                    Console.WriteLine("Preço da Gasolina:");
                    gasolina = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("O maior preço da gasolina foi de R${0}, já o menor preço foi de R${1}", MaiorG, MenorG);
                Console.WriteLine("O maior preço do diesel foi de R${0}, já o menor preço foi de R${1}", MaiorD, MenorD);
                Console.WriteLine("O maior preço do álcool foi de R${0}, já o menor preço foi de R${1}", MaiorA, MenorA);
                Console.WriteLine("Esses preços foram pesquisados em {0} postos", postos);
                Console.WriteLine("\nDeseja repetir o programa? (S/N)");
                rep = Console.ReadKey().KeyChar;
            } while (rep == 'S' || rep == 's');
        }
    }
}
