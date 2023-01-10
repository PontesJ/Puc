namespace Fila
{
    class Capsula
    {
        public string valor;         // Valor que estará presente dentro da capsula
        public Capsula apontador;    // Apontador para outra capsula
        public Capsula()             // Cria a primeira capsula
        {
            valor = "";              // O valor presente na primeira capsula será vazio
            apontador = null;        // O apontador apontará para nulo
        }
        public Capsula(string valor) // Cria uma nova capsula
        {
            this.valor = valor;      // O valor presente na capsula será o valor passado por parâmetro
            apontador = null;        // O apontador apontará para nulo
        }
    }
}
