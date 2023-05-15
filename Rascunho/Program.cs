class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10000, 0, 1000);

        Console.WriteLine("Array antes da ordenação:");
        PrintArray(array, 10000);

        InsertionSort(array);

        Console.WriteLine("Array após a ordenação:");
        PrintArray(array, 10000);
    }

    static void InsertionSort(int[] array)
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
            }

            array[j + 1] = key;
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