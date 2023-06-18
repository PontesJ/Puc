using System;
class Autonomo : PFisica
{
    public Autonomo(String n, double r, String c) : base(n, r, c) { }
    public override String mostrarSigla()
    {
        return "AUT";
    }
}