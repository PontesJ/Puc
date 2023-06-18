using System;
class MicroEmpIndividual : PFisica
{
    public MicroEmpIndividual(String n, double r, String c) : base(n, r, c) { }
    public override String mostrarSigla()
    {
        return "MEI";
    }
}