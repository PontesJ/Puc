using System;
using Atividade6.com.joao.Classes.Patos;
namespace Atividade6.com.joao.Classes
{
    static public class Atividade
    {
        static public void Executar()
        {
            RubberDuck borracha = new RubberDuck("Bob", 2, 12, 8);
            RedHeadDuck vermelho = new RedHeadDuck("Lix", 5, 72, 50);
            MallardDuck real = new MallardDuck("Charles", 7, 158, 65);
            WoodDuck madeira = new WoodDuck("Oak", 13, 40, 30);
            MetalDuck metal = new MetalDuck("Alul", 12, 554, 40);

            Colors.ciano(BoldAndUnderline.ambos("Atividade 6"));

            Colors.amarelo(BoldAndUnderline.negrito($"\nO pato de borracha {borracha.getNome()} tem {borracha.getIdade()} anos, pesa {borracha.getPeso() * 10}g e tem {borracha.getTamanho()}cm"));
            Colors.amarelo(BoldAndUnderline.negrito(borracha.display()));
            Colors.amarelo(BoldAndUnderline.negrito(borracha.quack()));
            Colors.amarelo(BoldAndUnderline.negrito(borracha.swim()));
            Console.ReadLine();
            
            Colors.vermelho(BoldAndUnderline.negrito($"O pato Redhead {vermelho.getNome()} tem {vermelho.getIdade()} anos, pesa {vermelho.getPeso() * 10}g e tem {vermelho.getTamanho()}cm"));
            Colors.vermelho(BoldAndUnderline.negrito(vermelho.display()));
            Colors.vermelho(BoldAndUnderline.negrito(vermelho.quack()));
            Colors.vermelho(BoldAndUnderline.negrito(vermelho.fly()));
            Colors.vermelho(BoldAndUnderline.negrito(vermelho.swim()));
            Console.ReadLine();

            Colors.verde(BoldAndUnderline.negrito($"O pato-real {real.getNome()} tem {real.getIdade()} anos, pesa {real.getPeso() * 10}g e tem {real.getTamanho()}cm"));
            Colors.verde(BoldAndUnderline.negrito(real.display()));
            Colors.verde(BoldAndUnderline.negrito(real.quack()));
            Colors.verde(BoldAndUnderline.negrito(real.fly()));
            Colors.verde(BoldAndUnderline.negrito(real.swim()));
            Console.ReadLine();

            Colors.magenta(BoldAndUnderline.negrito($"O pato de madeira {madeira.getNome()} tem {madeira.getIdade()} anos, pesa {madeira.getPeso() * 10}g e tem {madeira.getTamanho()}cm"));
            Colors.magenta(BoldAndUnderline.negrito(madeira.display()));
            Colors.magenta(BoldAndUnderline.negrito(madeira.swim()));
            Console.ReadLine();

            Colors.azul(BoldAndUnderline.negrito($"O pato de metal {metal.getNome()} tem {metal.getIdade()} anos, pesa {metal.getPeso() * 10}g e tem {metal.getTamanho()}cm"));
            Colors.azul(BoldAndUnderline.negrito(metal.display()));
        }
    }
}