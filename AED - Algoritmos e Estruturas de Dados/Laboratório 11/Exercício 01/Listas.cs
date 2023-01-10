using System;

namespace Exercício_01
{
    class Listas
    {
        private Capsula primeiro, ultimo;
        public Listas()
        {
            primeiro = new Capsula();
            ultimo = primeiro;
        }
        public int tam()
        {
            int aux = 0;
            for (Capsula i = primeiro; i != ultimo; i = i.frente)
            {
                aux++;
            }
            return aux;
        }
        public void adicionar(string num)
        {
            ultimo.frente = new Capsula(num);
            ultimo.frente.tras = ultimo;
            ultimo = ultimo.frente;
        }
        public void adicionar(string num, int pos)
        {
            int tamanho = tam();
            pos--;
            if (pos < 0 || pos > tamanho)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Valor Invalido");
                Console.ResetColor();
            }
            else if (pos == 0) // Add Início
            {
                Capsula aux = new Capsula(num);
                aux.tras = primeiro;
                aux.frente = primeiro.frente;
                primeiro.frente = aux;
                if (primeiro == ultimo)
                {
                    ultimo = aux;
                }
                else
                {
                    aux.frente.tras = aux;
                }
                aux = null;
            }
            else if (pos == tamanho) // Add Fim
            {
                adicionar(num);
            }
            else
            {
                Capsula aux = primeiro;
                for (int i = 0; i < pos; i++)
                {
                    aux = aux.frente;
                }
                Capsula aux2 = new Capsula(num);
                aux2.tras = aux;
                aux2.frente = aux.frente;
                aux2.tras.frente = aux2;
                aux2.frente.tras = aux2;
                aux = null;
                aux2 = null;
            }
        }
        public int remover()
        {
            if (primeiro == ultimo)
                return -1;
            else
                return 0;
        }
        public string remover(string num)
        {
            int pos = busca(num);
            if (pos < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Elemento Não Encontrado");
                Console.ResetColor();
                return "";
            }
            else if (pos == 0) // Remover Início
            {
                Capsula aux = primeiro;
                primeiro = primeiro.frente;
                string sair = primeiro.valor;
                primeiro.tras = null;
                aux.frente = null;
                aux = null;
                return sair;
            }
            else if (pos == (tam() - 1)) // Remover Fim
            {
                string sair = ultimo.valor;
                ultimo = ultimo.tras;
                ultimo.frente.tras = null;
                ultimo.frente = null;
                return sair;
            }
            else
            {
                Capsula aux = primeiro.frente;
                for (int i = 0; i < pos; i++)
                {
                    aux = aux.frente;
                }
                aux.tras.frente = aux.frente;
                aux.frente.tras = aux.tras;
                string sair = aux.valor;
                aux.frente = null;
                aux.tras = null;
                aux = null;
                return sair;
            }  
        }
        private int busca(string num)
        {
            int aux = 0;
            for (Capsula i = primeiro.frente; i != null; i = i.frente)
            {
                if (num == i.valor)
                {
                    return aux;
                }
                aux++;
            }
            return -1;
        }
        public void imprimi()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A lista: ");

            for (Capsula i = primeiro.frente; i != null; i = i.frente)
                Console.Write("{0} ", i.valor);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}