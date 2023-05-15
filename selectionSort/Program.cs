using System;
using System.Diagnostics;

class SelectionSort
{
    static void Main()
    {
        int[] arr = GenerateRandomArray(10000, 0, 1000);

        Console.WriteLine("Array antes da ordenação:");
        PrintArray(arr);

        Stopwatch stopwatch = Stopwatch.StartNew(); // Iniciar o cronômetro

        int comparacoes = 0;
        int movimentacoes = 0;

        SelectionSortAlgorithm(arr, ref comparacoes, ref movimentacoes);

        stopwatch.Stop(); // Parar o cronômetro

        Console.WriteLine("Array após a ordenação:");
        PrintArray(arr);

        long tempoExecucao = stopwatch.ElapsedMilliseconds;

        Console.WriteLine("Tempo de execução: " + tempoExecucao + " ms");
        Console.WriteLine("Número de comparações: " + comparacoes);
        Console.WriteLine("Número de movimentações: " + movimentacoes);
    }

    static void SelectionSortAlgorithm(int[] arr, ref int comparacoes, ref int movimentacoes)
    {
        int n = arr.Length;

        // Itera através de todos os elementos do array
        for (int i = 0; i < n - 1; i++)
        {
            // Encontra o elemento mínimo no array não ordenado
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                comparacoes++; // Incrementar o contador de comparações

                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }

            // Troca o elemento mínimo encontrado com o primeiro elemento não ordenado
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;

            movimentacoes += 3; // Incrementar o contador de movimentações (3 movimentações: troca de valores)
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
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(min, max + 1);
        }

        return array;
    }
}
