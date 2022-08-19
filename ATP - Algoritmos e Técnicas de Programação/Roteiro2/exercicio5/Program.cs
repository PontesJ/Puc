using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariominimo, salario, quantidade;
            Console.WriteLine("\nExercício 05 - Quantidade de Salários Mínimos Ganhos");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Digite o valor do sálario mínimo:");
            salariominimo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do seu sálario:");
            salario = double.Parse(Console.ReadLine());
            quantidade = salario / salariominimo;
            Console.WriteLine("A Quantidade de Sálarios Mínimos que você ganha é: " + quantidade);
            Console.ReadKey();
        }
    }
}
