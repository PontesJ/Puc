using System;
namespace Atividade6.com.joao.Classes.Patos
{
    abstract public class Duck
    {
        private String nome;
        private int idade;
        private double peso, tamanho;
        public Duck(String nome, int idade, double peso, double tamanho)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.tamanho = tamanho;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public void setTamanho(double tamanho)
        {
            this.tamanho = tamanho;
        }
        public String getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public double getPeso()
        {
            return peso;
        }
        public double getTamanho()
        {
            return tamanho;
        }

        abstract public String display();
    }
}