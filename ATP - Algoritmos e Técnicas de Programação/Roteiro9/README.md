# Roteiro 09

```
// Digitar essa funçao
void LeVetor( float []vetor)
{
    for (int i = 0; i < vetor.Length; i++ ) {
        Console.Write("Entre com a nota do aluno [{0}]", i+1);
        vetor[ i ] = float.Parse(Console.ReadLine());
    }
}
```

## Exercício 01

Declare **na função main()** dois vetores de inteiros A e B. Usando a função acima, ler dois conjuntos de 10 números, colocando cada conj em um vetor. Depois prencha um terceiro vetor C[] sendo que cada posição de C[] deverá correponder ao menor valor correspondente às respectivas posições nos vetores A[] e B[]. Finalmente imprima o resultado de C[].
Exemplo:
<ul>Informe primeiro conjunto: 5 10 15 20 25 30 35 40 45 50<br>Informe segundo conjunto: 1 12 13 14 35 26 71 48 19 10<br>Resultado: 1 10 13 14 25 26 35 40 19 10</ul>

**<a href="./exercicio01/Program.cs">Resolução</a>**

## Exercício 02

Faça um programa que leia um conjunto de números e os guarde em um vetor. Depois conte e imprima quantos números positivos e a seguir imprima estes números. Depois conte e imprima quantos números negativos e quais são eles. ATENÇÃO: os números positivos e negativos podem ser digitados em qualquer ordem, mas devem ser listados separados (os positivos primeiro, os negativos depois).

Exemplo: foram digitados os números: 10 -5 4 -11 -12 14 17
O programa deve exibir como resultado:
<ul>Números positivos: 4<br>São eles: 10, 4, 14, 17<br>Números negativos: 3<br>São eles: -5 -11 -12</ul>

**<a href="./exercício02/Program.cs">Resolução</a>**

## Exercício 03

Em uma cidade sabe-se que, em janeiro de um certo ano, não ocorreu temperatura inferior a 5°C, nem superior a 40°C.
Faça um programa que leia as temperaturas diárias (dos 10 primeiros dias) calcule e imprima:
a) A menor e a maior temperatura ocorrida
b) A temperatura média
c) Em quais dias a temperatura foi inferior a temperatura média.

**<a href="./exercicio03/Program.cs">Resolução</a>**

## Exercício 04

Faça um programa que defina um vetor de 120 caracteres, incluindo brancos e:
● Calcule e imprima quantos brancos existem na frase
● Calcule e imprima quantas vezes aparece a letra P (maiúscula ou minúscula)
● Dada uma letra qualquer fornecida pelo teclado, imprimir a primeira vez que ela aparece na frase.

**<a href="./exercício04/Program.cs">Resolução</a>**