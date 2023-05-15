using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10000, 0, 1000);

        Console.WriteLine("Array antes da ordenação:");
        PrintArray(array, 10000);

        Stopwatch stopwatch = Stopwatch.StartNew(); // Iniciar o cronômetro

        int comparacoes = 0;
        int movimentacoes = 0;

        InsertionSort(array, ref comparacoes, ref movimentacoes);

        stopwatch.Stop(); // Parar o cronômetro

        Console.WriteLine("Array após a ordenação:");
        PrintArray(array, 10000);

        // Obter o tempo de execução em milissegundos
        long tempoExecucao = stopwatch.ElapsedMilliseconds;

        Console.WriteLine("Tempo de execução: " + tempoExecucao + " ms");
        Console.WriteLine("Número de comparações: " + comparacoes);
        Console.WriteLine("Número de movimentações: " + movimentacoes);
    }

    static void InsertionSort(int[] array, ref int comparacoes, ref int movimentacoes)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
                comparacoes++; // Incrementar o contador de comparações
                movimentacoes++; // Incrementar o contador de movimentações
            }

            array[j + 1] = key;
            movimentacoes++; // Incrementar o contador de movimentações
        }
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

    static void PrintArray(int[] array, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
