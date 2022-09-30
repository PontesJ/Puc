using System;

namespace Exercício_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 09");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu e-mail: ");
            string email = Console.ReadLine();
            Console.Write("Digite seu telefone: ");
            int telefone = int.Parse(Console.ReadLine());
            Console.Write("Digite seu RG: ");
            string rg = Console.ReadLine();
            StreamWriter sw = new StreamWriter("../Textos/ex09.txt");
            sw.WriteLine(nome);
            sw.WriteLine(email);
            sw.WriteLine(telefone);
            sw.WriteLine(rg);
            sw.Close();
            StreamReader sr = new StreamReader("../Textos/ex09.txt");
            string linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
