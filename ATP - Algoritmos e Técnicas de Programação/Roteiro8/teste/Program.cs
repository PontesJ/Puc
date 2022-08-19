using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int numdias, ano = 0, mes = 0, dia = 0;
            numdias = int.Parse(Console.ReadLine());
            while (numdias > 0) {
                if (numdias >= 365) {
                    numdias -= 365;
                    ano ++;
                } else if (numdias >= 31) {
                    numdias -= 31;
                    mes ++;
                } else if (numdias >= 30) {
                    numdias -= 30;
                    mes ++;
                } else {
                    numdias --;
                    dia ++;
                }
            }
            Console.WriteLine("{0} dia {1} mes {2} ano", dia, mes, ano);
        }
    }
}
