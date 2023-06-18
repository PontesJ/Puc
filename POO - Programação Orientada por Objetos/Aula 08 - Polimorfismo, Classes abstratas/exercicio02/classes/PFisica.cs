using System;
public abstract class PFisica : Contribuinte
{
    protected String cpf;
    public PFisica(String n,double r,String c)
    {
        nome = n;
        rendaBrt = r;
        cpf = c;
    }
    public override double calcImposto()
    {
        double imposto;
        if (rendaBrt <= 1400.00)
        {
            imposto = 0;
        }
        else if (rendaBrt <= 2100.00)
        {
            imposto = (rendaBrt * 0.1) - 100.00;
        }
        else if (rendaBrt <= 2800.00)
        {
            imposto = (rendaBrt * 0.15) - 270.00;
        }
        else if (rendaBrt <= 3600.00)
        {
            imposto = (rendaBrt * 0.25) - 500.00;
        }
        else
        {
            imposto = (rendaBrt * 0.3) - 700.00;
        }
        return imposto;
    }
    abstract public String mostrarSigla();
}
