using System;
using Atividade6.com.joao.Classes.Interfaces;
namespace Atividade6.com.joao.Classes.Patos
{
    sealed public class RedHeadDuck : Duck, IFlyable, IQuackable, ISwimmable
    {
        public RedHeadDuck(String nome, int idade, double peso, double tamanho) : base (nome, idade, peso, tamanho){}
        public override String display()
        {
            return "O Redhead é uma espécie de pato que tem uma cabeça, pescoço e peito de cor marrom-avermelhada. Também tem uma garganta e barriga brancas, com um bico cinza-azulado.";
        }
        public String quack()
        {
            return "O grasnar de um pato Redhead é bastante semelhante ao de outras espécies de patos. É um som alto e grave que pode ser ouvido a alguma distância.";
        }
        public String fly()
        {
            return "Os Redheads voam mais rápido do que a maioria dos patos, com uma batida de asa rápida e superficial";
        }
        public String swim()
        {
            return "O nado do Redhead é similar ao dos demais patos. Além disso, ele é um pato mergulhador, especialmente adaptado para forragear debaixo d'água.";
        }
    }
}