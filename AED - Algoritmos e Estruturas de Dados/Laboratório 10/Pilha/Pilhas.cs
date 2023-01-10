using System;

namespace Pilha
{
    class Pilhas
    {
        private Capsula primeiro;              // Referencia primeiro (topo)
        public Pilhas()                        // Ao instanciar a pilha:
        {
            primeiro = null;                   // A referencia recebe nulo como valor
        }
        public void adicionar(string num)      // Função para adicionar um elemento na pilha
        {
            Capsula aux = new Capsula(num);    // Uma variável auxiliar (aux) recebe uma capsula com o valor recebido por parâmetro
            aux.apontador = primeiro;          // O apontador da variável auxiliar apontará para onde esta a referencia primeiro
            primeiro = aux;                    // A referencia primeiro irá para a variável auxiliar
            aux = null;                        // A variável auxiliar é destruída
        }
        public string remover()                // Função para remover um elemento da pilha
        {
            if (primeiro == null)              // Se a pilha estiver vazia, sem nenhum elemento, retorna uma string vazia
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pilha Vazia");
                Console.ResetColor();
                return "";
            }
            string sair = primeiro.valor;      // Uma variável auxiliar (sair) recebe o valor que a referencia primeiro esta
            Capsula aux = primeiro;            // Outra variável auxiliar (aux) recebe a referencia primeiro
            primeiro = primeiro.apontador;     // A referencia primeiro irá para a proxima capsula
            aux.apontador = null;              // O ponteiro da variável auxiliar "aux" apontará para nulo
            aux = null;                        // A variável auxiliar "aux" é destruída
            return sair;                       // A variável auxiliar "sair" é retornada
        }
        public void imprimi()                  // Função para chamar a função de imprimir a pilha
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A pilha: ");
            imprimi(primeiro);                 // Chama a função imprimir passando a referencia primeiro como parâmetro
            Console.WriteLine();
            Console.ResetColor();
        }
        private void imprimi(Capsula primeiro) // Função para imprimir a pilha
        {
            if (primeiro != null)              // Se a referencia primeiro estiver em uma capsula
            {
                imprimi(primeiro.apontador);   // Chama a função e forma recursiva
                Console.Write("{0} ", primeiro.valor); // Imprimi o valor atual do primeiro
            }
        }
    }
}