using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double cateto1, cateto2, hipotenusa;
            Console.WriteLine("\nExercício 06 - Descubra o valor da Hipotenusa");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Digite o valor do primeiro cateto:");
            cateto1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo cateto");
            cateto2 = double.Parse(Console.ReadLine());
            hipotenusa = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
            hipotenusa = Math.Sqrt(hipotenusa);
            Console.WriteLine("A Hipotenusa desse triângulo é: " + hipotenusa);
            Console.ReadKey();
        }
    }
}
