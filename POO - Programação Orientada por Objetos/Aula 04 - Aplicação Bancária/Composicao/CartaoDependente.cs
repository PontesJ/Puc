using System;

namespace Aula_04___Aplicação_Bancária
{
    class CartaoDependente
    {
        private int cvc;
        private long numero;
        private String validade, dependente;
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
        public void setDependente(String dependente)
        {
            this.dependente = dependente;
        }
        public String getDependente()
        {
            return dependente;
        }
    }
}