using System;
using Atividade6.com.joao.Classes.Interfaces;
namespace Atividade6.com.joao.Classes.Patos
{
    sealed public class MetalDuck : Duck
    {
        public MetalDuck(String nome, int idade, double peso, double tamanho) : base (nome, idade, peso, tamanho){}
        public override String display()
        {
            return "Pato feito de metal, geralmente pode ser encontrado em jardins e prateleiras como objeto de decoração";
        }
    }
}