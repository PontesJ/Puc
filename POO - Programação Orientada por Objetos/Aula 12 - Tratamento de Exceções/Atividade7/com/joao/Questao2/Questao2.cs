using System;
namespace Atividade7.com.joao.Questao2
{
    public static class Questao2
    {
        public static void Executar()
        {
            char opcao = 'a';
            double num1, num2;
            Colors.ciano(BoldAndUnderline.ambos("Exercício 2\n"));
            while (true)
            {
                Console.Write(BoldAndUnderline.negrito("Digite o primeiro número: "));
                try
                {
                    num1 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException erro)
                {
                    Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado não é um número!"));
                    Colors.vermelho(BoldAndUnderline.negrito($"{erro.Message}\n"));
                }
            }
            while (true)
            {
                Console.Write(BoldAndUnderline.negrito("Digite o segundo número: "));
                try
                {
                    num2 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException erro)
                {
                    Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado não é um número!"));
                    Colors.vermelho(BoldAndUnderline.negrito($"{erro.Message}\n"));
                }
            }
            
            obterOpcao(ref opcao);

            while (true)
            {
                if (opcao == '+')
                {
                    Colors.verde(BoldAndUnderline.negrito($"\nA soma entre {num1} + {num2} = {num1 + num2}\n"));
                    break;
                }
                else if (opcao == '-')
                {
                    Colors.verde(BoldAndUnderline.negrito($"\nA subtração entre {num1} - {num2} = {num1 - num2}\n"));
                    break;
                }
                else if (opcao == '*')
                {
                    Colors.verde(BoldAndUnderline.negrito($"\nA multiplicação entre {num1} * {num2} = {num1 * num2}\n"));
                    break;
                }
                else if (opcao == '/')
                {
                    if (num2 != 0)
                    {
                        Colors.verde(BoldAndUnderline.negrito($"\nA divisão entre {num1} / {num2} = {num1/num2}\n"));
                        break;
                    }
                    Colors.vermelho(BoldAndUnderline.negrito("\nImpossível dividir por zero!\n"));
                    obterOpcao(ref opcao);
                }
                else if (opcao == '%')
                {
                    if (num2 != 0)
                    {
                        Colors.verde(BoldAndUnderline.negrito($"\nA resto da divisão entre {num1} % {num2} = {num1%num2}\n"));
                        break;
                    }
                    Colors.vermelho(BoldAndUnderline.negrito("\nImpossível dividir por zero!\n"));
                    obterOpcao(ref opcao);
                }
                else
                {
                    Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado não corresponde a uma opção!\n"));
                    obterOpcao(ref opcao);
                }
            }
        }
        private static void obterOpcao (ref char opcao)
        {
            while (true)
            {
                Console.WriteLine(BoldAndUnderline.negrito("Digite a operação selecionada: Soma [+] | Substração [-] | Multiplicação [*] | Divisão [/] | Módulo [%]"));
                try
                {
                    opcao = char.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException erro)
                {
                    Colors.vermelho(BoldAndUnderline.negrito("\nValor digitado não corresponde a uma opção!\n"));
                    Colors.vermelho(BoldAndUnderline.negrito($"{erro.Message}\n"));
                }
            }
        }
    }
}