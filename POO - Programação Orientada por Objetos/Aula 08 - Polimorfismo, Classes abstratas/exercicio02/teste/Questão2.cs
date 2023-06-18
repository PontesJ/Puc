using System;

class Questão2
{
    public static void Questao2 ()
    {
        Contribuinte [] lista = new Contribuinte[5];
        int i = 0;
        bool aut = true, mei = true, fi = true, me = true, epp = true;
        while (i < lista.Length)
        {
            Console.WriteLine("Digite qual opção deseja adicionar (apenas uma de cada)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Autonomo [1] / MicroEmpIndividual [2] / FirmaIndividual [3] / MicroEmpresa [4] / EmpresaPequenoPorte [5]: ");
            Console.ResetColor();
            int aux = int.Parse(Console.ReadLine());
            if (aux == 1 && aut == true)
            {
                autonomo(lista, i);
                aut = false;
                i++;
            }
            else if (aux == 2 && mei == true)
            {
                microempindividual(lista, i);
                mei = false;
                i++;
            }
            else if (aux == 3 && fi == true)
            {
                firmaindividual(lista, i);
                fi = false;
                i++;
            }
            else if (aux == 4 && me == true)
            {
                microempresa(lista, i);
                me = false;
                i++;
            }
            else if (aux == 5 && epp == true)
            {
                empresapequenoporte(lista, i);
                epp = false;
                i++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor Invalido");
                Console.ResetColor();
            }
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ordenado:\n");
        Console.ResetColor();
        Merge.Ordenar(lista);
        for (int j=0; j<lista.Length; j++)
        {
            Console.WriteLine($"{lista[j].getNome()} possui de imposto R${lista[j].calcImposto()}");
        }
    }
    private static void autonomo (Contribuinte [] lista, int i)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Digite as informações sobre o AUT");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Nome: ");
        Console.ResetColor();
        String nome = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Valor Bruto: ");
        Console.ResetColor();
        double valor = Double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("CPF: ");
        Console.ResetColor();
        String cpf = Console.ReadLine();
        lista[i] = new Autonomo(nome, valor, cpf);
    }
    private static void microempindividual(Contribuinte [] lista, int i)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Digite as informações sobre o MEI");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Nome: ");
        Console.ResetColor();
        String nome = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Valor Bruto: ");
        Console.ResetColor();
        double valor = Double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("CPF: ");
        Console.ResetColor();
        String cpf = Console.ReadLine();
        lista[i] = new MicroEmpIndividual(nome, valor, cpf);
    }
    private static void firmaindividual(Contribuinte [] lista, int i)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Digite as informações sobre o FI");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Nome: ");
        Console.ResetColor();
        String nome = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Valor Bruto: ");
        Console.ResetColor();
        double valor = Double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("CNPJ: ");
        Console.ResetColor();
        String cnpj = Console.ReadLine();
        lista[i] = new FirmaIndividual(nome, valor, cnpj);
    }
    private static void microempresa(Contribuinte [] lista, int i)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Digite as informações sobre o ME");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Nome: ");
        Console.ResetColor();
        String nome = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Valor Bruto: ");
        Console.ResetColor();
        double valor = Double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("CNPJ: ");
        Console.ResetColor();
        String cnpj = Console.ReadLine();
        lista[i] = new MicroEmpresa(nome, valor, cnpj);
    }
    private static void empresapequenoporte(Contribuinte [] lista, int i)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Digite as informações sobre o EPP");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Nome: ");
        Console.ResetColor();
        String nome = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Valor Bruto: ");
        Console.ResetColor();
        double valor = Double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("CNPJ: ");
        Console.ResetColor();
        String cnpj = Console.ReadLine();
        lista[i] = new EmpresaPequenoPorte(nome, valor, cnpj);
    }
}