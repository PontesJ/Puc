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