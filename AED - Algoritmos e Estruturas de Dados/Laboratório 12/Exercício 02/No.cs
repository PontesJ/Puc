using System;

namespace Exercício_02
{
    class No
    {
        public int valor, nivel;
        public No esquerda;
        public No direita;
        public No(int valor)
        {
            this.Nos(valor, null, null, 1);
        }
        void Nos(int valor, No esquerda, No direita, int nivel)
        {
            this.valor = valor;
            this.esquerda = esquerda;
            this.direita = direita;
            this.nivel = nivel;
        }
        public void setNivel()
        {
            this.nivel = 1 + Math.Max(getNivel(esquerda), getNivel(direita));
        }
        public static int getNivel(No no)
        {
            return (no == null) ? 0 : no.nivel;
        }
    }
}
