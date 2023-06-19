using System;
static public class Colors
{
    public static void vermelho(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    public static void ciano(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    public static void ciano(string mensagem, int i)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(mensagem);
        Console.ResetColor();
    }
    public static void verde(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    public static void amarelo(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    public static void magenta(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    public static void azul(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
}