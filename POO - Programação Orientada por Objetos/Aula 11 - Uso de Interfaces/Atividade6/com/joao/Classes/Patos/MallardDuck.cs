using System;
using Atividade6.com.joao.Classes.Interfaces;
namespace Atividade6.com.joao.Classes.Patos
{
    sealed public class MallardDuck : Duck, IFlyable, IQuackable, ISwimmable
    {
        public MallardDuck(String nome, int idade, double peso, double tamanho) : base (nome, idade, peso, tamanho){}
        public override String display()
        {
            return "Os machos possuem a cabeça de cor verde, com asas e barrigas acinzentadas. Já o peito é castanho escuro e ele possui um anel branco ao redor do pescoço. Já as fêmeas de Pato-Real possuem as penas em um tom castanho-amarronzado";
        }
        public String quack()
        {
            return "A fêmea do Pato-Real é quem produz o som de grasnar que é associado aos patos em geral. O macho não grasna; em vez disso, ele emite um chamado mais silencioso, rouco, de uma ou duas notas";
        }
        public String fly()
        {
            return "O Pato-Real é um forte voador que geralmente voa abaixo de 10.000 pés, mas durante a migração voará em altitudes entre 200 a 4.000 pés. Além disso, começam a voar por curtos períodos, aos 10-12 semanas e estarão voando bem aos 16 semanas";
        }
        public String swim()
        {
            return "O Pato-Real é um dos mais rápidos nadadores, atingindo velocidades de cerca de 4-6 mph. Tornando ele uma das aves aquáticas mais rápidas do mundo.";
        }
    }
}