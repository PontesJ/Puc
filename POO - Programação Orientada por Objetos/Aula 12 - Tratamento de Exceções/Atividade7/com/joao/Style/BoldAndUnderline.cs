static public class BoldAndUnderline
{
    public static string negrito(string mensagem)
    {
        return $"\x1B[1m{mensagem}\x1B[0m";
    }
    public static string sublinhado(string mensagem)
    {
        return $"\x1B[4m{mensagem}\x1B[0m";
    }
    public static string ambos(string mensagem)
    {
        return $"\x1B[1m\x1B[4m{mensagem}\x1B[0m\x1B[0m";
    }
}