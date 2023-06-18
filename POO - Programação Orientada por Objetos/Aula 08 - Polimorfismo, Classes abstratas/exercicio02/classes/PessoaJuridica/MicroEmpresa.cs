using System;
class MicroEmpresa : PJuridica
{
    public MicroEmpresa(String n, double r, String c) : base(n, r, c) { }
    public override String mostrarSigla()
    {
        return "ME";
    }
}