using System;
class EmpresaPequenoPorte : PJuridica 
{
    public EmpresaPequenoPorte(String n, double r, String c) : base(n, r, c) { }
    public override String mostrarSigla()
    {
        return "EPP";
    }
}