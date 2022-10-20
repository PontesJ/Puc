## Funções em ATP

### Função para ver se um número é primo ou não:

```
static int primo(int n)
{
    int p = 0;
    for (int m = n; 1 <= m; m--)
    {
        if (n % m == 0) p++;
    }
    if (p > 2) return 0;
    else return 1;
}   
```

### Função para ler um vetor:

```
static void lerVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write("Entre com o {0} número: ", i + 1);
        vetor[i] = int.Parse(Console.ReadLine());
    }
}
```

### Função para imprimir um vetor:

```
static void imprimirVetor(int[] vetor)
{
    for (int i = 0; i < vetor.length; i++)
    {
        Console.Write("{0} ", vetor[i]);
    }
}
```

### Função para ler matriz:

```
static void lerMatriz(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.WriteLine("Digite o {0}° valor da {1}° linha: ", j + 1, i + 1);
            matriz[i, j] = int.Parse(Console.ReadLine());
        }
    }
}
```

### Função para imprimir matriz:

```
static void imprimirMatriz(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
```

### Função para imprimir arquivo:

```
static void lerArquivo()
{
    StreamReader ler = new StreamReader("../textos/texto.txt");
    string linha = ler.ReadLine();
    while (linha != null)
    {
        Console.WriteLine(linha);
        linha = ler.ReadLine();
    }
    ler.Close();
}
```