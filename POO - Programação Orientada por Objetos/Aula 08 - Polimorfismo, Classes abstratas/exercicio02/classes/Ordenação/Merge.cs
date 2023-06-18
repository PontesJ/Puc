using System;



    class Merge
    {
        static void mergeSort(Contribuinte [] vetor, int inicio, int tam)
        {
            if (inicio < tam)
            {
                int metade = inicio + (tam - inicio) / 2;
                mergeSort(vetor, inicio, metade);
                mergeSort(vetor, metade + 1, tam);
                merge(vetor, inicio, metade, tam);
            }
        }
        static void merge(Contribuinte [] vetor, int inicio, int metade, int tam)
        {
            int i, j, k;
            int parte1 = metade - inicio + 1;
            int parte2 = tam - metade;
            Contribuinte[] vetor1 = new Contribuinte[parte1];
            Contribuinte[] vetor2 = new Contribuinte[parte2];
            for (i = 0; i < parte1; i++) vetor1[i] = vetor[inicio + i];
            for (j = 0; j < parte2; j++) vetor2[j] = vetor[metade + 1 + j];
            i = 0;
            j = 0;
            k = inicio;
            for (; i < parte1 && j < parte2; k++)
            {
                if (vetor1[i].calcImposto() <= vetor2[j].calcImposto())
                {
                    vetor[k] = vetor1[i];
                    i++;
                }
                else
                {
                    vetor[k] = vetor2[j];
                    j++;
                }
            }
            for (; i < parte1; i++, k++) vetor[k] = vetor1[i];
            for (; j < parte2; j++, k++) vetor[k] = vetor2[j];
        }
        public static void Ordenar(Contribuinte [] vetor)
        {
            mergeSort(vetor, 0, vetor.Length - 1);
        }
    }
