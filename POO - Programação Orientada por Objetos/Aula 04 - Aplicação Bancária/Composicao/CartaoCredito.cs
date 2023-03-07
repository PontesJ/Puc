using System;

namespace Aula_04___Aplicação_Bancária
{
    class CartaoCredito
    {
        private int cvc;
        private long numero;
        private String validade, titular;
        private CartaoDependente dependente;

        public void setCartaoDependente(CartaoDependente dependente)
        {
            this.dependente = dependente;
        }
        public CartaoDependente getCartaoDependente()
        {
            return dependente;
        }
        public void setNumero(long numero)
        {
            this.numero = numero;
        }
        public long getNumero()
        {
            return numero;
        }
        public void setCVC(int cvc)
        {
            this.cvc = cvc;
        }
        public int getCVC()
        {
            return cvc;
        }
        public void setValidade(String validade)
        {
            this.validade = validade;
        }
        public String getValidade()
        {
            return validade;
        }
        public void setTitular(String titular)
        {
            this.titular = titular;
        }
        public String getTitular()
        {
            return titular;
        }
    }
}