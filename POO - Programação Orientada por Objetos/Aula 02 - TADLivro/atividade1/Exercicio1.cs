using System;
public static class Exercicio1
{
    public static void Buscar(String autor, Livro[] vetor)
    {
        int aux = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i].getAutor() == autor)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{vetor[i].getTitulo()}, de {vetor[i].getAutor()}");
                Console.ResetColor();
                aux++;
            }
        }
        if (aux == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nNão foi possível encontrar o autor {autor}");
            Console.ResetColor();
        }
    }
}
