using System;

namespace exercicio05
{
    class Program
    {
        static int conversor (int dia, int mes, int ano) {
            int dias = 0;
            dias += dia;
            while (ano > 1900) {
                dias += 365;
                ano --;
            }
            for (; mes > 1; mes--) {
                if (mes == 2 || mes == 4 || mes == 6 || mes == 8 || mes == 9 || mes == 11) dias += 31;
                if (mes == 5 || mes == 7 || mes == 10 || mes == 12) dias += 30;
                if (mes == 3) {
                    if (ano % 4 == 0) dias += 29;
                    else dias += 28;
                }
            }
            if (ano == 1900) dias--;
            return dias;
        }   
        
         static void Main(string[] args)
        {
            int dia, mes, ano, c;
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            ano = int.Parse(Console.ReadLine());
            c = conversor(dia, mes, ano);
            Console.WriteLine(c);
        } 
    }
}
