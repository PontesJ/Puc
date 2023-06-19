using System;
namespace Atividade7.com.joao.Questao1
{
    public static class Questao1
    {
        public static void Executar()
        {
            int num1 = 0, aux, primo = 0;
            Colors.ciano(BoldAndUnderline.ambos("Exercício 1\n"));
            while (true)
            {
                Console.Write(BoldAndUnderline.negrito("Digite um número inteiro: "));
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException erro)
                {
                    Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado não é um inteiro!"));
                    Colors.vermelho(BoldAndUnderline.negrito($"{erro.Message}\n"));
                }
                catch (OverflowException erro)
                {
                    Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado é muito grande!"));
                    Colors.vermelho(BoldAndUnderline.negrito($"{erro.Message}\n"));
                }
            }
            
            for (aux = num1 - 1; aux > 1; aux--)
            {
                if (num1 % aux == 0)
                {
                    primo = 1;
                    break;
                }
            }
            if (primo == 1)
            {
                Colors.amarelo(BoldAndUnderline.negrito($"\nO número {num1} não é primo\n"));
            }
            else
            {
                if (num1 == 0)
                {
                    Colors.amarelo(BoldAndUnderline.negrito($"\nO número {num1} não é primo\n"));
                }
                else
                {
                    Colors.verde(BoldAndUnderline.negrito($"\nO número {num1} é primo\n"));
                }
            }
        }
    }
}