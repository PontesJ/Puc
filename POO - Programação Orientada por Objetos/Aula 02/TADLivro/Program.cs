using System;

namespace TADLivro
{
    class Program
    {
        static void printVetor(Livro[] vetor)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{vetor[i].getTitulo()}, {vetor[i].getAno()}");
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("============================================================\n");
            Livro[] vetor = new Livro[5];
            vetor[0] = new Livro("O Universo numa casa de Noz", "Stephen Hawking", "Física", 2001);
            vetor[1] = new Livro("Cem Anos de Solidão", "Gabriel Garcia Matos", "Romance", 1967);
            vetor[2] = new Livro("Ariana, a Mulher", "Vinicius de Morais", "Poesia", 1936);
            vetor[3] = new Livro("Prosopopeia", "Bento Teixeira", "Poema", 1601);
            vetor[4] = new Livro("O guia do mochileiro das galáxias", "Douglas Adams", "Ficção", 1981);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Os Livros:\n");
            Console.ResetColor();
            printVetor(vetor);

            vetor[0].ordenar(vetor);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nOrdenados por ano:\n");
            Console.ResetColor();
            printVetor(vetor);

            Console.WriteLine("\n============================================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite o nome do autor que deseja buscar pelas obras: ");
            Console.ResetColor();
            String autor = Console.ReadLine();
            Exercicio1.Buscar(autor, vetor);

            Console.WriteLine("\n============================================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite o nome do gênero que deseja buscar pelas obras: ");
            Console.ResetColor();
            String genero = Console.ReadLine();
            Exercicio2.BuscarGenero(genero, vetor);

            Console.WriteLine("\n============================================================\n");
        }
    }
}