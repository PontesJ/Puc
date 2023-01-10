using System;

namespace Lista
{
    class Listas
    {
        private Capsula primeiro, ultimo;    // Referencia primeiro e ultimo
        public Listas()                      // Instancia a lista
        {
            primeiro = new Capsula();        // Cria a primeira capsula
            ultimo = primeiro;               // A referencia do ultimo é a mesma do primeiro
        }
        public int tam()                     // Função para saber o tamanho da lista
        {
            int aux = 0;
            for (Capsula i = primeiro; i != ultimo; i = i.apontador) // Enquanto a referencia primeiro for diferente da ultima, um contador receberá um acréscimo, logo depois, a proxima capsula é recebida
            {
                aux++;
            }
            return aux;
        }
        public void adicionar(string num)          // Função para adicionar elementos na lista
        {
            ultimo.apontador = new Capsula(num);   // Cria uma nova capsula que recebe o valor enviado por parâmetro
            ultimo = ultimo.apontador;             // A referencia do ultimo é deslocada para a nova capsula
        }
        public void adicionar(string num, int pos) // Função para adicionar elementos na lista, em determinada posição
        {
            int tamanho = tam();
            pos--;                                 // Valor na forma de maquina
            if (pos < 0 || pos > tamanho)            // Se a posição for menor que 0 ou maior que o tamanho da lista, imprimi um erro
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Valor Invalido");
                Console.ResetColor();
            }
            else if (pos == 0) // Add Início
            {
                Capsula aux = new Capsula(num);
                aux.apontador = primeiro.apontador;
                primeiro.apontador = aux;
                if (primeiro == ultimo)
                {
                    ultimo = aux;
                }
                aux = null;
            }
            else if (pos == tamanho) // Add Fim
            {
                adicionar(num);
            }
            else                                 // Senão
            {
                Capsula aux = primeiro;          // Uma variável auxiliar (aux) recebe a posição de referencia da variável primeiro
                for (int i = 0; i < pos; i++)    // Loop para chegar na posição requerida
                {
                    aux = aux.apontador;
                }
                Capsula aux2 = new Capsula(num); // Uma capsula (aux2) é criada com o valor passado por parâmetro
                aux2.apontador = aux.apontador;  // O ponteiro dessa capsula apontará para onde o ponteiro que a capsula encontrada no loop apontava
                aux.apontador = aux2;            // O ponteiro da capsula do loop apontará para a nova capsula
                aux = null;                      // A variável "aux" é destruída
                aux2 = null;                     // A variável "aux2" é destruída
            }
        }
        public int remover()        // Função para conferir se a lista está vazia
        {
            if (primeiro == ultimo) // Se a lista estiver vazia retorna -1
                return -1;
            else                    // Se a lista não estiver vazia retorna 0
                return 0;
        }
        public string remover(string num) // Função para remover determinado número da lista
        {
            int pos = busca(num);         // A posição do número é recebido pela variável auxiliar "pos"
            if (pos < 0)                  // Se a variável pos for menor que 0, o elemento não existe na lista
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Elemento Não Encontrado");
                Console.ResetColor();
                return "";
            }
            else if (pos == 0) // Remover Início
            {
                Capsula aux = primeiro;
                primeiro = primeiro.apontador;
                string sair = primeiro.valor;
                aux.apontador = null;
                aux = null;
                return sair;
            }
            else if (pos == (tam() - 1)) // Remover Fim
            {
                Capsula aux;
                for (aux = primeiro; aux.apontador != ultimo; aux = aux.apontador);
                string sair = ultimo.valor;
                ultimo = aux;
                ultimo.apontador = null;   
                aux = null;
                return sair;
            }
            else                                // Senão
            {
                Capsula aux = primeiro;         // Uma variável auxiliar (aux) recebe a posição de referencia da variável primeiro
                for (int i = 0; i < pos; i++)   // Loop para chegar na posição requerida
                {
                    aux = aux.apontador;
                }
                Capsula aux2 = aux.apontador;   // Outra variável auxiliar (aux2) recebe a referencia da capsula a ser removido
                string sair = aux2.valor;       // Uma terceira variável auxiliar "sair" é criada, recebendo o valor a ser retornado
                aux.apontador = aux2.apontador; // O apontador da variável "aux" apontará para onde o apontador da capsula, que será removida apontava
                aux2.apontador = null;          // O apontador da capsula a ser removida é apontado para nulo
                aux = null;                     // A variável "aux" é destruída
                aux2 = null;                    // A variável "aux2" é destruída
                return sair;                    // A variável "sair" é retornada
            }  
        }
        private int busca(string num)                                        // Função para buscar o valor na lista
        {
            int aux = 0;
            for (Capsula i = primeiro.apontador; i != null; i = i.apontador) // O loop percorrerá toda a lista
            {
                if (num == i.valor)                                          // Se encontrar o valor
                {
                    return aux;                                              // Retorna a posição
                }
                aux++;                                                       // Senão acrescenta mais 1 na posição e volta para o loop
            }
            return -1;                                                       // Se o valor não existir retorna -1
        }
        public void imprimi() // Função para imprimir a fila
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A lista: ");

            for (Capsula i = primeiro.apontador; i != null; i = i.apontador) // Enquanto o apontador da capsula não apontar para nulo, o valor presente na capsula é impresso, logo depois, a proxima capsula é recebida
                Console.Write("{0} ", i.valor);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}