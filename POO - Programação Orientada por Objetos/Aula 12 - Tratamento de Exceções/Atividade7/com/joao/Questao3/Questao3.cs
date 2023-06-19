using System;
using System.Linq;
namespace Atividade7.com.joao.Questao3
{
    public static class Questao3
    {
        public static void Executar()
        {
            int [] vetor = new int [10];
            int num, pos;
            Colors.ciano(BoldAndUnderline.ambos("Exercício 3"));
            while (true)
            {
                num = inserirNumero();
                
                while (true)
                {
                    Console.Write(BoldAndUnderline.negrito("Digite a posição desejada para inserir o número (de 1 até 10): "));
                    try
                    {
                        pos = (int.Parse(Console.ReadLine()) - 1);
                        vetor[pos] = num;
                        break;
                    }
                    catch (FormatException erro)
                    {
                        Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado não é um inteiro"));
                        Colors.vermelho(BoldAndUnderline.negrito($"{erro.Message}\n"));
                    }
                    catch (IndexOutOfRangeException erro)
                    {
                        Colors.vermelho(BoldAndUnderline.negrito("\nPosição invalida"));
                        Colors.vermelho(BoldAndUnderline.negrito($"{erro.Message}\n"));
                    }
                    catch (OverflowException erro)
                    {
                        Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado é muito grande!"));
                        Colors.vermelho(BoldAndUnderline.negrito($"{erro.Message}\n"));
                    }
                }

                if (vetor.All(x => x != 0))
                {
                    break;
                }
            }
            Colors.ciano(BoldAndUnderline.negrito("\nVetor: "), 1);
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(BoldAndUnderline.negrito($"{vetor[i]} "));
            }
            Console.WriteLine("\n");
        }
        private static int inserirNumero()
        {
            int num;
            while (true)
            {
                Console.Write(BoldAndUnderline.negrito($"\nDigite um número para inseri-lo: "));
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num == 0)
                    {
                        throw new EZero("\nNão insira o número 0");
                    }
                    break;
                }
                catch (FormatException erro)
                {
                    Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado não é um inteiro"));
                    Colors.vermelho(BoldAndUnderline.negrito(erro.Message));
                }
                catch (EZero erro)
                {
                    Colors.vermelho(BoldAndUnderline.negrito(erro.Message));
                }
                catch (OverflowException erro)
                {
                    Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado é muito grande!"));
                    Colors.vermelho(BoldAndUnderline.negrito(erro.Message));
                }
            }
            return num;
        }
    }
}