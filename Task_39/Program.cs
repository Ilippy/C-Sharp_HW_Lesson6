// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray(10, 0, 10);
        System.Console.WriteLine($"[{String.Join(", ", array)}]");
        ShowChangeArray(array);
        System.Console.WriteLine();
        ChangeArray(array);
        System.Console.WriteLine($"[{String.Join(", ", array)}]");

    }

    static int[] CreateRandomArray(int size, int start, int end)
    {
        int[] RandomArray = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            RandomArray[i] = random.Next(start, end);
        }
        return RandomArray;
    }

    static void ShowChangeArray(int[] array)
    {


        for (int i = array.Length - 1; i >= 0; i--)
        {
            System.Console.Write(array[i] + " ");
        }
    }

    static void ChangeArray(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length / 2; i++)
        {
            temp = array[i];
            array[i] = array[^(i+1)];   // array[^(i+1)] = array[array.Length -1 - i]
            // array[i] = array[array.Length - 1 - i];  // 9 8 7 6 5 4
            array[^(i+1)] = temp;
            // array[array.Length - 1 - i] = temp;      // 4 5 6 7 8 9
        }
    }
}