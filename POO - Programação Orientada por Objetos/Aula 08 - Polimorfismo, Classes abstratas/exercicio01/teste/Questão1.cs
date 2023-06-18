using System;

class Questão1
{
    public static void Questao1 ()
    {
        Contribuinte []lst;
        lst= Contribuinte.listaContr();
        Console.WriteLine("NOME IMPOSTO\n");
        Console.WriteLine("==================== =======\n\n");
        for (int i=0; i<lst.Length; i++)
        {
            Console.WriteLine($"O individuo {lst[i].getNome()} pagará de imposto R${lst[i].calcImposto()}");
            Console.WriteLine(" ");
        }
    }
}