using System;
using Atividade6.com.joao.Classes.Interfaces;
namespace Atividade6.com.joao.Classes.Patos
{
    sealed public class WoodDuck : Duck, ISwimmable
    {
        public WoodDuck(String nome, int idade, double peso, double tamanho) : base (nome, idade, peso, tamanho){}
        public override String display()
        {
            return "Pato feito de madeira, geralmente utilizado para decoração ou por crianças como brinquedo, pode ser encontrado em quartos ou em outro ambiente para decoração";
        }
        public String swim()
        {
            return "O pato de madeira flutua sobre a água, se movendo de acordo com as correntezas";
        }
    }
}