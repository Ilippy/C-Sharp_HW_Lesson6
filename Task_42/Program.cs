// Задача 42: На ишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


internal partial class Program
{
    private static void Main(string[] args)
    {
        // int[] array = CreateRandomArray(10, 0, 10);

        int number = EnterNumber("Введите число в десятичной системе");

        System.Console.WriteLine($"{number} -> {DecimalToBinary(number)}");
        System.Console.WriteLine($"{number} -> {Transfer(number)}");
        System.Console.WriteLine($"{number} -> {TransferToBinary(number)}");

    }

    static string DecimalToBinary(int number)
    {
        string res = String.Empty;
        string x1 = String.Empty;
        while (number > 0)
        {
            x1 = (number % 2).ToString();
            res += x1;
            number = number / 2;
        }
        char[] strChar = res.ToCharArray();
        Array.Reverse(strChar);
        res = String.Join("", strChar);
        return res;
    }


    static int Transfer(int number)
    {
        int temp = 0;
        List<int> list = new List<int>();
        while (number > 0)
        {
            temp = number % 2;
            number = number / 2;
            list.Add(temp);
        }
        return Revert(list);
    }
    //переворачивает число и возвращает прямую запись двоичного числа.
    static int Revert(List<int> list)
    {
        int[] s = new int[list.Count];
        for (int i = list.Count - 1; i >= 0; i--)
        {
            s[list.Count - 1 - i] = list[i];
        }
        return Convert.ToInt32(string.Join<int>("", s));
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

    static int TransferToBinary(int number)
    {
        int pow = 0;

        // pow - степень числа 2 при которой значение 2 в степени pow максимально близко к заданному числу, но не больше его.

        for (int i = 0; Math.Pow(2, i) <= number; i++)
        {
            pow = i;
        }

        int size = pow + 1;
        int[] array = new int[size];


        for (int i = 0; i < size; i++)
        {
            if (number >= Math.Pow(2, pow))
            {
                array[i] = 1;
                number = number - (int)Math.Pow(2, pow);
            }
            else array[i] = 0;
            pow = pow - 1;

        }
        return Convert.ToInt32(String.Join("",array));
    }

}