using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariohora, hora, salariobruto, desconto, salarioliquido;
            Console.WriteLine("\nExercício 09 - Salário Líquido");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o valor do salário hora");
            salariohora = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas de trabalho:");
            hora = double.Parse(Console.ReadLine());
            salariobruto = salariohora * hora;
            if (salariobruto < 350) {
                Console.WriteLine("Seu salário líquido é de R${0}", salariobruto);
            } else {
                if (salariobruto > 350 && salariobruto < 1000) {
                    desconto = 0.1 * salariobruto;
                    salarioliquido = salariobruto - desconto;
                    Console.WriteLine("Seu salário líquido é de R${0}", salarioliquido);
                } else {
                    desconto = 0.2 * salariobruto;
                    salarioliquido = salariobruto - desconto;
                    Console.WriteLine("Seu salário líquido é de R${0}", salarioliquido);
                }
            }
        }
    }
}
