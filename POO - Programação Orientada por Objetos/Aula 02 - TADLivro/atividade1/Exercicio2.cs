using System;
public static class Exercicio2
{
    public static void BuscarGenero(String genero, Livro[] vetor)
    {
        int aux = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i].getGenero() == genero)
            {
                aux++;
            }
        }
        if (aux == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nO gênero {genero} não foi encontrado");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nO gênero {genero} foi encontrado {aux} vez(es)");
            Console.ResetColor();
        }
    }
}