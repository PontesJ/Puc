using System;

namespace ex04
{
    class Program
    {
        static int letras (string frase, char letra){
            if (frase == "") return 0;
            if (frase[0] == letra) return letras (frase.Substring (1), letra) + 1;
            return letras (frase.Substring (1), letra); 
        }
        static void Main(string[] args)
        {
            int n = letras("paralelepipedo", 'e');
            Console.WriteLine(n);
        }
    }
}
