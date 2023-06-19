using System;
using Atividade6.com.joao.Classes.Interfaces;
namespace Atividade6.com.joao.Classes.Patos
{
    sealed public class RubberDuck : Duck, IQuackable, ISwimmable
    {
        public RubberDuck(String nome, int idade, double peso, double tamanho) : base (nome, idade, peso, tamanho){}
        public override String display()
        {
            return "Patinho de borracha, geralmente encontrado em banheiros e banheiras";
        }
        public String quack()
        {
            return "Quack-Quack";
        }
        public String swim()
        {
            return "O pato de borracha flutua sobre a água, se movendo de acordo com as correntezas";
        }
    }
}