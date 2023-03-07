using System;

public class Livro 
{
    private String titulo, autor, genero;
    private int ano;

    public Livro(string titulo, string autor, string genero, int ano)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.ano = ano;
    }

    public void setTitulo(String titulo)
    {
        this.titulo = titulo;
    }
    public String getTitulo()
    {
        return this.titulo = titulo;
    }
    public void setAutor(String autor)
    {
        this.autor = autor;
    }
    public String getAutor()
    {
        return this.autor = autor;
    }
    public void setGenero(String genero)
    {
        this.genero = genero;
    }
    public String getGenero()
    {
        return this.genero = genero;
    }
    public void setAno(int ano)
    {
        this.ano = ano;
    }
    public int getAno()
    {
        return this.ano = ano;
    }
    public Boolean barroco(Livro livro)
    {
        int ano = livro.getAno();
        if(ano >= 1601 && ano <= 1768) return true;
        return false;
    }
    public Boolean modernismo(Livro livro)
    {
        int ano = livro.getAno();
        if(ano >= 1930 && ano <= 1945) return true;
        return false;
    }
    public void ordenar(Livro[] vetor)
    {
        for (int i = 0; i < 5; i++)
        {
            int pos = i;
            for (int j = i; j < 5; j++)
            {
                if (vetor[j].getAno() <= vetor[pos].getAno())
                {
                    pos = j;
                }
            }
            Livro aux = vetor[pos];
            vetor[pos] = vetor[i];
            vetor[i] = aux;
        }
    }
}