# Roteiro 08

## Exercício 01

Faça um programa que contenha uma função que receba dois números inteiros como parâmetro de entrada e leia um valor do teclado que esteja entre os dois parâmetros passados. A função deve retornar o número correto para o programa principal e este deve imprimir o valor lido.
Exemplo:
```
// digite aqui a função le_no_intervalo()

void Main(String[] args)
{
    int dia, mes;
    Console.WriteLine("Informe o dia entre 1 e 31: ");
    dia = le_no_intervalo(1, 31);
    Console.WriteLine("Informe o mes entre 1 e 12: ");
    mes = le_no_intervalo(1, 12);
    Console.WriteLine("Data: {0}/{1}", dia, mes);
}
```
**<a href="./exercicio01/Program.cs">Resolução</a>**

## Exercício 02

Faça uma função que receba um número inteiro positivo como parâmetro, e caso este número seja primo retorne 1, caso contrário retorne 0. Número primo é aquele que só é divisível por 1 e por ele mesmo.

**<a href="./exercicio02/Program.cs">Resolução</a>**

## Exercício 03

Faça uma função que receba três números inteiros como parâmetros, representando horas, minutos e segundos, e retorne o seu valor convertido em segundos.
Exemplo: 2h, 40 min e 10 seg = 9.610 segundos

**<a href="./exercicio03/Program.cs">Resolução</a>**

## Exercício 04

Faça uma função que receba como parâmetro de entrada, a quantidade de segundos e, calcule e retorne como parâmetros de saída, três inteiros representando a: hora, minutos e segundos equivalentes.
Exemplo: 9.610 segundos = 2h, 40 min e 10 seg.
Use como parâmetros de saída parâmetros do tipo: (**ref int var**)

**<a href="./exercicio04/Program.cs">Resolução</a>**

## Exercício 05

Faça uma função que receba três números representando o dia, mês e ano de uma data. A função deverá calcular quantos dias se passaram entre esta data e o dia 01/01/1900. Para simplificar as coisas considere os meses: 1, 3, 5, 7, 8, 10 e 12 como sendo de 31 dias e os demais 30. Para os “avançadinhos” façam para o caso real, ou seja: fevereiro tem 28 dias exceto em anos bissextos (a cada 4 anos)

**<a href="./exercicio05/Program.cs">Resolução</a>**

## Exercício 06

Faça agora uma função que receba uma quantidade de dias corridos e os transforme em dias, meses e anos (retornados como parâmetros de saída), tendo como dia Zero o dia 01/01/1900. Datas negativas são anteriores a este dia.
Para testar essa função utilize a função do exercício anterior para calcular quantos dias, meses e anos entre o dia de hoje e algumas datas especiais tais como:

- Dia do seu nascimento
- Dia em que você começou a namorar
- Dia em que você começou estudar para essa disciplina (ontem ?? )
- Ultima vez que viu o seu time ganhar (já faz tempo ? rsrs)
- Etc ....

**<a href="./exercicio06/Program.cs">Resolução</a>**