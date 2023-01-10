using System;

namespace Exercício_01
{
    class ArvoreBinaria
    {
        No raiz;
        public ArvoreBinaria()
        {
            raiz = null;
        }
        public void inserir(int num)
        {
            raiz = inserir(num, raiz);
        }
        No inserir(int num, No atual)
        {
            if (atual == null)
            {
                atual = new No(num);
            }
            else if (num < atual.valor)
            {
                atual.esquerda = inserir(num, atual.esquerda);
            }
            else if (num > atual.valor)
            {
                atual.direita = inserir(num, atual.direita);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nValor já inserido");
                Console.ResetColor();
            }
            return atual;
        }
        public void remover (int num)
        {
            raiz = remover(num, raiz);
        }
        No remover (int num, No atual)
        {
            if (atual == null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nA Árvore Está Vazia");
                Console.ResetColor();
            }
            else if (num < atual.valor)
            {
                atual.esquerda = remover(num, atual.esquerda);
            }
            else if (num > atual.valor)
            {
                atual.direita = remover(num, atual.direita);
            }
            else if (atual.direita == null)
            {
                atual = atual.esquerda;
            }
            else if (atual.esquerda == null)
            {
                atual = atual.direita;
            }
            else
            {
                atual.esquerda = maiorEsquerda(atual, atual.esquerda);
            }
            return atual;
        }
        No maiorEsquerda (No atual, No esquerda)
        {
            if (esquerda.direita == null)
            {
                atual.valor = esquerda.valor;
                esquerda = esquerda.esquerda;
            }
            else
            {
                esquerda.direita = maiorEsquerda(atual, esquerda.direita);
            }
            return esquerda;
        }
        public Boolean pesquisa(int num)
        {
            return pesquisa(num, raiz);
        }
        private Boolean pesquisa(int num, No atual)
        {
            Boolean resp;
            if (atual == null)
            {
                resp = false;
            }
            else if (num == atual.valor)
            {
                resp = true;
            }
            else if (num < atual.valor)
            {
                resp = pesquisa(num, atual.esquerda);
            }
            else
            {
                resp = pesquisa(num, atual.direita);
            }
            return resp;
        }
        public void emOrdem()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nÁrvore Em Ordem: ");
            Console.ResetColor();
            emOrdem(raiz);
            Console.WriteLine();
        }
        public void preOrdem()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nÁrvore Em Pré-Ordem: ");
            Console.ResetColor();
            preOrdem(raiz);
            Console.WriteLine();
        }
        public void posOrdem()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nÁrvore Em Pós-Ordem: ");
            Console.ResetColor();
            posOrdem(raiz);
            Console.WriteLine();
        }
        void emOrdem (No atual)
        {
            if (atual != null)
            {
                emOrdem(atual.esquerda);
                Console.Write("{0} ", atual.valor);
                emOrdem(atual.direita);
            }
        }
        void preOrdem (No atual)
        {
            if (atual != null)
            {
                Console.Write("{0} ", atual.valor);
                preOrdem(atual.esquerda);
                preOrdem(atual.direita);
            }
        }
        void posOrdem (No atual)
        {
            if (atual != null)
            {
                posOrdem(atual.esquerda);
                posOrdem(atual.direita);
                Console.Write("{0} ", atual.valor);
            }
        }
    }
}
