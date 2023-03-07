using System;

namespace Aula_04___Aplicação_Bancária
{
    class Conta
    {
        private int numero, saldo;
        private String titular, cpf;
        private CartaoCredito cartaoCredito;

        public void setCartaoCredito(CartaoCredito cartaoCredito)
        {
            this.cartaoCredito = cartaoCredito;
        }
        public CartaoCredito getCartaoCredito()
        {
            return cartaoCredito;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return numero;
        }
        public void setSaldo(int saldo)
        {
            this.saldo = saldo;
        }
        public int getSaldo()
        {
            return saldo;
        }
        public void setTitular(String titular)
        {
            this.titular = titular;
        }
        public String getTitular()
        {
            return titular;
        }
        public void setCPF(String cpf)
        {
            this.cpf = cpf;
        }
        public String getCPF()
        {
            return cpf;
        }
    }
}