using System;
class FirmaIndividual : PJuridica
{
    public FirmaIndividual(String n, double r, String c) : base(n, r, c) { }
    public override String mostrarSigla()
    {
        return "FI";
    }
}