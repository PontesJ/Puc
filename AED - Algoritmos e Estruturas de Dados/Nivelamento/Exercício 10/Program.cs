using System;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 10");
            Console.Write("Deseja fazer um novo cadastro? (S/N): ");
            char opcao = (char)Console.Read();
            if (opcao == 's' || opcao == 'S'){
                Console.WriteLine("Novo cadastro");
                string teste = Console.ReadLine();
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite seu peso (Kg): ");
                double peso = double.Parse(Console.ReadLine());
                Console.Write("Digite sua altura (M): ");
                double altura = double.Parse(Console.ReadLine());
                StreamWriter sw = new StreamWriter("../Textos/ex10.txt", true);
                sw.WriteLine(nome);
                sw.WriteLine(peso / (altura * altura));
                sw.Close();
            } else {
                StreamReader sr = new StreamReader("../Textos/ex10.txt");
                string linha = sr.ReadLine();
                while (linha != null) {
                    Console.WriteLine(linha);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
        }
    }
}
