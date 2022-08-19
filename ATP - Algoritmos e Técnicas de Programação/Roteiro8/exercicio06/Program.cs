using System;

namespace exercicio06
{
    class Program
    {
        static void conversor (int dias, ref int dia, ref int mes, ref int ano) {
            if (dias >= 0) {
                while (dias >= 365) {
                    ano ++;
                    dias -= 365;
                }
                while (dias >= 31) {
                    mes ++;
                    dias -= 31;
                }
                while (dias >= 30) {
                    mes ++;
                    dias -= 30;
                }
                while (dias >= 28) {
                    mes ++;
                    dias -= 28;
                }
                while (dias > 0) {
                    dia ++;
                    dias --;
                }
                dia += 1;
                mes += 1;
                ano += 1900;
            } else {
                while (dias <= -365) {
                    ano --;
                    dias += 365;
                }
                while (dias <= -31) {
                    mes --;
                    dias += 31;
                }
                while (dias <= -30) {
                    mes --;
                    dias += 30;
                }
                while (dias <= -28) {
                    mes --;
                    dias += 28;
                }
                while (dias < 0) {
                    dia --;
                    dias ++;
                }
                dia = 1 + dia;
                mes = 1 + mes;
                ano = 1900 + ano;
                if (dia < 0) dia *= -1;
                if (mes < 0) mes *= -1;
                if (ano < 0) ano *= -1;
            }
        }
        
        static void Main(string[] args)
        {
            int n1, dia1 = 0, mes1 = 0, ano1 = 0;
            n1 = int.Parse(Console.ReadLine());
            conversor(n1, ref dia1, ref mes1, ref ano1);
            Console.WriteLine("{0}/{1}/{2}", dia1, mes1, ano1);
        }
    }
}
