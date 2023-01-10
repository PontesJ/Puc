namespace Exercício_01
{
    class No
    {
        public int valor;
        public No esquerda;
        public No direita;
        public No(int valor)
        {
            this.Nos(valor,null,null);
        }
        void Nos(int valor, No esquerda, No direita)
        {
            this.valor = valor;
            this.esquerda = esquerda;
            this.direita = direita;
        }
    }
}
