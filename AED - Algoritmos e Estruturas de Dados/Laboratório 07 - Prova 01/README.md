# Prova 01

## Questão 01

1\. Modele, projete e calcule a complexidade de um programa que: (20%)<br>
a. Leia as linhas de um arquivo chamado "arq1.txt".<br>
b. Peça para o usuário inserir um texto no terminal/console.<br>
c. Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos "IGUAIS" e "DIFERENTE".<br>
d. Descreva quais as operações relevantes.

**<a href="./Questão 01/Program.cs">Código</a>**

## Questão 02

2\. Dado o código a seguir, responda: (25%)<br>
a. Quantos e quais são os casos base/condições de parada para a função funcRec1()?<br>
b. Explique com suas palavras o que a função funcRec1() calcula.<br>
c. Represente a pilha de execução para a chamada funcRec1(6).

```
Int funcRec1(int a){
    If(a<=1)
        Return 0;
    Else
        Return funcRec1((a-2)+5);
}
```

**<a href="./Questão 02/Program.cs">Código</a>**

## Questão 03

3\. Modele, projete e calcule a complexidade de um programa que: (20%)<br>
a. Leia a primeira linha de um arquivo chamado "entrada.txt".<br>
b. Escreva em um arquivo chamado "saida.txt" o conteúdo lido no arquivo de entrada ao contrário.<br>
c. Descreva quais as operações relevantes.

Exemplo de entrada e saída esperados:

"entrada.txt" &rarr; olá, tudo bem?

"saida.txt" &rarr; ?meb odut ,álo

Observações: considere que o arquivo "entrada.txt" contenha no mínimo uma linha de conteúdo.

**<a href="./Questão 03/Program.cs">Código</a>**

## Questão 04

4\. Um banco famoso enfrenta problemas de consulta em seu banco de registros. Dentre os problemas identificados pela gerência está a localização das contas dos seus titulares nas listagens e nos relatórios impressos em diferentes situações. Um especialista de TI sugeriu ordenar as contas por meio dos CPF dos seus n titulares antes das impressões. Dentre alguns algoritmos pré-selecionados para essa ordenação, o especialista escolheu o algoritmo de ordenação por inserção. Se você fosse o especialista, responda: (20%)<br>
a. O especialista escolheu um bom algoritmo? Justifique.<br>
b. Qual algoritmo de ordenação utilizaria? Justifique.<br>
c. Descreva quais as operações relevantes.<br>
d. Demonstre a viabilidade da sua solução para 10 registros.

**<a href="./Questão 04/Program.cs">Código</a>**

## Questão 05

5\. O código a seguir implementa uma função recursiva. Analise-o e indique o que será retornado pela função, caso os parâmetros possuam os seguintes dados: v = {10, 5, 7, 15, 22, 9, 30} e a = 6. (15%)

```
int funcao (int a, int v[7])
{
    if (a == 1)
        return v[0];
    else {
        int x;
        x = funcao (a-1, v);

        if (x > v[a-1])
            return x;
        
        else
            return v[a-1];
    }
}
```

**<a href="./Questão 05/Program.cs">Código</a>**