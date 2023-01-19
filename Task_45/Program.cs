// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] arr = CreateRandomArray(10, 10, 100);
        System.Console.WriteLine($"old array = [{String.Join(", ", arr)}]");
        int[] array = CopyArray(arr);
        System.Console.WriteLine($"new array = [{String.Join(", ", array)}]");



    }

    static int[] CopyArray(int[] array)
    {
        int[] coppyArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            coppyArray[i] = array[i];
        }
        return coppyArray;
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
}