## Funções em AED

### Função para calcular o fatorial de um número natural:

```
static void Fatorial(int N, int Fat)
{
    if (N >= 0)
    {
        if (N == 0) Console.WriteLine("\nO fatorial de 0 é: 1");
        else
        {
            int Cont = N;
            while (Cont > 1)
            {
                N = N * (Cont - 1);
                Cont--;
            }
            Console.WriteLine("\nO fatorial de {0} é: {1}", Fat, N);
        }
    }
    else Console.WriteLine("Não é possível calcular fatorial de número negativo");
}
```

### Função recursiva para contar quantidade de determinada letra em uma palavra/frase:

```
static int letras(string frase, char letra)
{
    if (frase == "") return 0;
    if (frase[0] == letra) return letras(frase.Substring(1), letra) + 1;
    return letras(frase.Substring(1), letra);
}
```

### Função recursiva para somar valores pares de um vetor:

```
static int soma(int[] vetor, int tam)
{
    if (tam == 0) return 0;
    if (vetor[tam - 1] % 2 == 0) return vetor[tam - 1] + soma(vetor, tam - 1);
    return soma(vetor, tam - 1);
}
```

### Função recursiva para retirar vogais minusculas de uma palavra/frase:

```
static string vogais(string frase)
{
    if (frase == "") return "";
    if (frase[frase.Length - 1] == 'a' || frase[frase.Length - 1] == 'e' || frase[frase.Length - 1] == 'i' || frase[frase.Length - 1] == 'o' || frase[frase.Length - 1] == 'u') return vogais(frase.Substring(0, frase.Length - 1));
    return vogais(frase.Substring(0, frase.Length - 1)) + frase[frase.Length - 1];
}
```

### Função recursiva para calcular a sequência de Fibonacci:

```
static int Fibonacci(int x)
{
    if (x <= 0) return 0;
    if (x == 1) return 1;
    return Fibonacci(x - 1) + Fibonacci(x - 2);
}
```

### Função recursiva de busca binária:

```
static int buscaBinaria(int[] vetor, int inicio, int tam, int numero)
{
    if (inicio <= tam)
    {
        int metade = inicio + (tam - inicio) / 2;
        if (vetor[metade] == numero) return metade + 1;
        if (vetor[metade] > numero) return buscaBinaria(vetor, inicio, metade - 1, numero);
        return buscaBinaria(vetor, metade + 1, tam, numero);
    }
    return -1;
}
```