namespace Relacionamentos{

    class CaixaRegistradora
    {
        public void entrePagamento(double valor, Moeda tipoMoeda){
            tipoMoeda.valor = valor;
            tipoMoeda.nome = "Real";

        }
    }
}