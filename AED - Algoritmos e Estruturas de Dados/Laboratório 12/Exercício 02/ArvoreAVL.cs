using System;

namespace Exercício_02
{
    class ArvoreAVL
    {
        private No raiz;
        public ArvoreAVL()
        {
            raiz = null;
        }
        No balancear(No no)
        {
            if (no != null)
            {
                int fator = No.getNivel(no.direita) - No.getNivel(no.esquerda);
                if (Math.Abs(fator) <= 1)
                {
                    no.setNivel();
                }
                else if (fator == 2)
                {
                    int fatorFilhoDireita = No.getNivel(no.direita.direita) - No.getNivel(no.direita.esquerda);
                    if (fatorFilhoDireita == -1)
                    {
                        no.direita = rotacionarDireita(no.direita);
                    }
                    no = rotacionarEsquerda(no);
                }
                else if (fator == -2)
                {
                    int fatorFilhoEsquerda = No.getNivel(no.esquerda.direita) - No.getNivel(no.esquerda.esquerda);
                    if (fatorFilhoEsquerda == 1)
                    {
                        no.esquerda = rotacionarEsquerda(no.esquerda);
                    }
                    no = rotacionarDireita(no);
                }
                else
                {
                    Console.WriteLine("Erro");
                }
            }
            return no;
        }
        No rotacionarDireita(No no)
        {
            No noEsquerda = no.esquerda;
            No noEsquerdaDireita = noEsquerda.direita;
            noEsquerda.direita = no;
            no.esquerda = noEsquerdaDireita;
            no.setNivel(); // Atualizar o nível do no
            noEsquerda.setNivel(); // Atualizar o nível do noEsquerda
            return noEsquerda;
        }
        No rotacionarEsquerda(No no)
        {
            No noDireita = no.direita;
            No noDireitaEsquerda = noDireita.esquerda;
            noDireita.esquerda = no;
            no.direita = noDireitaEsquerda;
            no.setNivel(); // Atualizar o nível do no
            noDireita.setNivel(); // Atualizar o nível do noDireita
            return noDireita;
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
            return balancear(atual);
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
            return balancear(atual);
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