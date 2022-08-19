using System;

namespace extra2
{
    class Program
    {
        static string vogais (string frase) {
            if (frase == "") return "";
            if (frase[0] == 'a' || frase[0] == 'e' || frase[0] == 'i' || frase[0] == 'o' || frase[0] == 'u') return vogais (frase.Substring (1));
            return vogais (frase.Substring (1)) + frase[0];
        }
        static string inverter(string frase)
        {
            char[] letra = frase.ToCharArray();
            Array.Reverse(letra);
            string inverso = new String(letra);
            return inverso;
        }
        static void Main(string[] args)
        {
            string n = vogais("paralelepipedo");
            n = inverter (n);
            Console.WriteLine(n);
        }
    }
}
