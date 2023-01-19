// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше
// суммы двух других сторон.

internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateArray(3);
        System.Console.WriteLine($"{CheckArray(array)}");
    }

    static int[] CreateArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = EnterNumber($"Введите {i + 1} элемент массива");
        }
        return array;
    }

    static bool CheckArray(int[] array)
    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > array[max]) max = i;
        }
        int sum =0;
        for (int i = 0; i < array.Length; i++)
        {
            if(i != max) sum += array[i];
        }
        return (array[max] < sum ? true : false);
    }


    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number))
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }
}