using System;

namespace Aula_04___Aplicação_Bancária
{
    public static class Composicao
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAplicação Bancária\n");
            Console.ResetColor();

            // Informações Da Conta/Titular
            Conta cliente = new Conta();
            cliente.setNumero(01);
            cliente.setSaldo(25000);
            cliente.setTitular("João Gustavo Medeiros Pontes");
            cliente.setCPF("123.345.678-90");
            
            // Informações do Cartão de Crédito
            CartaoCredito cartaoC = new CartaoCredito();
            cartaoC.setNumero(1234567898765432);
            cartaoC.setValidade("01/26");
            cartaoC.setCVC(278);
            cartaoC.setTitular("JOAO GUSTAVO PONTES");
            
            // Informações do Cartão de Crédito Dependente
            CartaoDependente cartaoD = new CartaoDependente();
            cartaoD.setNumero(9876543212345678);
            cartaoD.setValidade("02/27");
            cartaoD.setCVC(142);
            cartaoD.setDependente("MARIA LUCIA PONTES");

            // Set Cartão de Crédito Dependente
            cartaoC.setCartaoDependente(cartaoD);

            // Set Cartão de Crédito
            cliente.setCartaoCredito(cartaoC);

            while (1 == 1)
            {
                Console.WriteLine("=============================================================");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nQual classe deseja acessar?");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nConta [1] | Cartão de Crédito [2] | Cartão Dependente [3]: ");
                Console.ResetColor();
                int i = int.Parse(Console.ReadLine());

                // Impressão das Informações da Conta
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nNome do Titular: ");
                    Console.ResetColor();
                    Console.Write(cliente.getTitular() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("CPF do Titular: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCPF() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Número do Titular: ");
                    Console.ResetColor();
                    Console.Write(cliente.getNumero() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Saldo do Titular: ");
                    Console.ResetColor();
                    Console.Write(cliente.getSaldo() + "\n");
                    break;
                }

                // Informações do Cartão de Crédito
                else if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nTitular: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCartaoCredito().getTitular() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Número: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCartaoCredito().getNumero() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Validade: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCartaoCredito().getValidade() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("CVC: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCartaoCredito().getCVC() + "\n");
                    break;
                }

                // Informações do Cartão de Crédito Dependente
                else if (i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nDependente: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCartaoCredito().getCartaoDependente().getDependente() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Número: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCartaoCredito().getCartaoDependente().getNumero() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Validade: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCartaoCredito().getCartaoDependente().getValidade() + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("CVC: ");
                    Console.ResetColor();
                    Console.Write(cliente.getCartaoCredito().getCartaoDependente().getCVC() + "\n");
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nValor Invalido!");
                Console.ResetColor();
            }
            Console.WriteLine("\n=============================================================\n");
        }
    }
}