// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        bool isPlayerKnowQuantityOfNumbers = Convert.ToBoolean(Numbers.EnterNumber("Введите 0, если вы не знаетет," +
         "сколько чисел вы хотите ввести или 1, если знаете", 0, 1));
        int[] array;
        if (isPlayerKnowQuantityOfNumbers)
            array = GetArray();
        else
            array = GetArrayFromList();
        Console.Clear();
        System.Console.WriteLine($"[{String.Join(", ", array)}] -> {GetPositiveNumbersInArray(array)}");
    }



    static int[] GetArray()
    {
        int size = Numbers.EnterNumber("Введите сколько чисел, Вы собираетесь ввести в проемежутке[1,20]", 1, 20);
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = Numbers.EnterNumber($"Введите {i + 1} целое число");
        }
        return array;
    }

    static int[] GetArrayFromList()
    {
        int i = 1;
        List<int> list = new List<int>();
        do
        {
            list.Add(Numbers.EnterNumber($"Введите {i} целое число"));
            i++;
            Console.WriteLine("Нажмите Esc, чтобы закончить, или любую другую клавишу для продолжения");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        return list.ToArray();
    }

    static int GetPositiveNumbersInArray(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0) result++;
        }
        return result;
    }
}