# Roteiro 06

## Exercício 01

Faça um programa que leia um número indeterminado de valores da tela. Quando for informado o valor Zero, o programa deve parar de solicitar os números e exibir a soma dos valores anteriormente digitados.

**<a href="./exercicio01/Program.cs">Resolução</a>**

## Exercício 02

Acrescente um contador no programa anterior para informar a quantidade de valores que foram lidos.

**<a href="./exercicio02/Program.cs">Resolução</a>**

## Exercício 03

Complete o programa abaixo que deverá calcular o Fatorial de vários Números. A estrutura para solicitar diversos números já está pronta, falta apenas o algoritmo do cálculo do fatorial.
```
void Main(String[] args) // Programa para Calcular fatorial
{
    int N, Cont, Fat=1;
    char repetir;
    do {
        Console.WriteLine("EXEMPLO PARA CALCULAR FATORIAL DE N");
        Console.WriteLine("Entre com um valor para cálculo do fatorial: ");
        N = int.Parse(Console.ReadLine());
        if (N >= 0) {
            //
            // Coloque aqui o código para cálculo do fatorial
            //
            Console.WriteLine("O fatorial de {0} é {1}", N, Fat);
        } else Console.WriteLine("Não posso calcular fatorial de número negativo");
        Console.WriteLine("\n Deseja repetir o programa ? (S / N)
        repetir = Console.ReadKey().KeyChar;
    } while (repetir == 'S' || repetir == 's');
}
```
**<a href="./exercicio03/Program.cs">Resolução</a>**

## Exercício 04

Acrescente comandos no exercício 2 que permita que o programa seja executado várias vezes, a exemplo do que foi feito no exercício 3.

**<a href="./exercicio04/Program.cs">Resolução</a>**

## Exercício 05

Foi feita uma pesquisa em um número indeterminado de postos dos preços da gasolina, do álcool e do diesel. Ler para cada posto, os valores de cada combustível, calcular e imprimir o maior e o menor valor encontrado para cada tipo de combustível dentre os postos pesquisados. Os dados terminam quando for digitado um valor de preço de gasolina igual a Zero. Colocar no final a opção para repetir tudo de novo.

**<a href="./exercicio05/Program.cs">Resolução</a>**