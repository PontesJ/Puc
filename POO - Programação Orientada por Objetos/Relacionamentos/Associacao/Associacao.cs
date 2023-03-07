using System;

namespace Relacionamentos{

    public static class Associacao
    {
        public static void Executar(){
            Console.WriteLine("Testando a Associacao");
          
            Cliente cliente = new Cliente("Fábio", "123.345.678-90");
            ContaAntes conta = new ContaAntes(1, 10, cliente);

            Console.WriteLine("Numero da Conta: " + conta.numero + "\n" +
                              "\n" +"\n" + "Saldo: " + conta.saldo + "\n" +
                               "Titular: " +conta.titular.nome + "\n" +
                               "CPF: " +conta.titular.cpf); 
        }        
    }

}