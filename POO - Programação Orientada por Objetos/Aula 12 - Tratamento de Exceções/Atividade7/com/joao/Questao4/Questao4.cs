using System;
namespace Atividade7.com.joao.Questao4
{
    public static class Questao4
    {
        public static void Executar()
        {
            int cont = 0;
            double soma = 0, num = 0;
            bool acima = false;
            Colors.ciano(BoldAndUnderline.ambos("Exercício 4"));
            while (true)
            {
                while(true)
                {
                    Console.Write(BoldAndUnderline.negrito("\nDigite um número para se somar: "));
                    try
                    {
                        num = double.Parse(Console.ReadLine());
                        if (num + soma > 100)
                        {
                            throw new ExcecaoAcimaDeCem("\nSoma ultrapassou 100.\n");
                        }
                        break;
                    }
                    catch (FormatException erro)
                    {
                        Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado não é um número"));
                        Colors.vermelho(BoldAndUnderline.negrito(erro.Message));
                    }
                    catch (ExcecaoAcimaDeCem erro)
                    {
                        Colors.vermelho(BoldAndUnderline.ambos(erro.Message));
                        acima = true;
                        break;
                    }
                }
                if (acima)
                {
                    break;
                }
                soma += num;
                cont++;
                Colors.magenta(BoldAndUnderline.negrito($"Soma atual: {soma}"));
            }
            Colors.azul(BoldAndUnderline.negrito($"A soma total foi: {soma}"));
            Colors.amarelo(BoldAndUnderline.negrito($"Foram somados {cont} números"));
            Colors.verde(BoldAndUnderline.negrito($"A média foi: {soma/cont}"));
        }
    }
}