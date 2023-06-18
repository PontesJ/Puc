using System;
public abstract class Contribuinte
{
    protected String nome;
    protected double rendaBrt;
    public String getNome()
    {
        return nome;
    }
    public double getValor()
    {
        return rendaBrt;
    }
    abstract public double calcImposto();
}