namespace Relacionamentos{

    class ContaAntes
    {
        public int numero {get ; set;}
        public double saldo {get; set;}
        public Cliente titular {get; set;}

        public ContaAntes(int numero, double saldo, Cliente titular)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.titular = titular;
        }
    }


}