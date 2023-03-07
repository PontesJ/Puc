using System; 

namespace Relacionamentos{

    public static class Dependencia
    {
        public static void Executar(){
            Console.WriteLine("Testando a Dependência");
            CaixaRegistradora caixa = new CaixaRegistradora();
            Moeda coin = new Moeda(1, "Real");
            caixa.entrePagamento(100, coin);

            Console.WriteLine(coin.valor);
        }        
    }

}