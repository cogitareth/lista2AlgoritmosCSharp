using System;
using System.Diagnostics;

class BubbleSort
{
    static void Main()
    {
        int[] arr = GenerateRandomArray(10000, 0, 1000);
        Console.WriteLine("Array antes da ordenação:");
        PrintArray(arr);

        Stopwatch stopwatch = Stopwatch.StartNew(); // Iniciar o cronômetro
        int comparacoes = 0;
        int movimentacoes = 0;

        BubbleSortAlgorithm(arr, ref comparacoes, ref movimentacoes);
        stopwatch.Stop(); // Parar o cronômetro

        Console.WriteLine("Array após a ordenação:");
        PrintArray(arr);

        long tempoExecucao = stopwatch.ElapsedMilliseconds;
        Console.WriteLine("Tempo de execução: " + tempoExecucao + " ms");
        Console.WriteLine("Número de comparações: " + comparacoes);
        Console.WriteLine("Número de movimentações: " + movimentacoes);
    }

    static void BubbleSortAlgorithm(int[] arr, ref int comparacoes, ref int movimentacoes)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // A cada passagem, o maior elemento "flutua" para o final do array
            for (int j = 0; j < n - i - 1; j++)
            {
                comparacoes++; // Incrementar o contador de comparações

                // Compara elementos adjacentes e realiza a troca se estiverem fora de ordem
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    movimentacoes += 3; // Incrementar o contador de movimentações (3 movimentações: troca de valores)
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static int[] GenerateRandomArray(int size, int min, int max)
    {
        int[] arr = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(min, max + 1);
        }

        return arr;
    }
}
