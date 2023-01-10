using System;

namespace Fila
{
    class Filas
    {
        private Capsula primeiro, ultimo;        // Referencia primeiro e ultimo
        public Filas()                           // Ao instanciar a fila:
        {
            primeiro = new Capsula();            // Cria a primeira capsula
            ultimo = primeiro;                   // A referencia do ultimo é a mesma do primeiro
        }
        public void adicionar(string num)        // Função para adicionar elementos na fila
        {
            ultimo.apontador = new Capsula(num); // Cria uma nova capsula que recebe o valor enviado por parâmetro
            ultimo = ultimo.apontador;           // A referencia do ultimo é deslocada para a nova capsula
        }
        public string remover()                  // Função para remover elementos da fila
        {
            if (primeiro == ultimo)              // Se a fila estiver vazia, sem nenhum elemento, retorna uma string vazia
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Fila Vazia");
                Console.ResetColor();
                return "";
            }
            Capsula aux = primeiro;              // Uma variável auxiliar (aux) recebe a posição de referencia da variável primeiro
            primeiro = primeiro.apontador;       // A variável primeiro recebe a referencia da proxima capsula 
            string sair = primeiro.valor;        // Uma outra variável auxiliar (sair) recebe o valor presente na capsula primeiro
            aux.apontador = null;                // O ponteiro da variável "aux" irá apontar para nulo
            aux = null;                          // A variável "aux" é destruída
            return sair;                         // O valor da primeira capsula que tinha sido armazenado na variável "sair" é retornado
        }
        public void imprimi()                    // Imprimi a fila
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A fila: ");

            for (Capsula i = primeiro.apontador; i != null; i = i.apontador) // Enquanto o apontador da capsula não apontar para nulo, o valor presente na capsula é impresso, logo depois, a proxima capsula é recebida
                Console.Write("{0} ", i.valor);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}