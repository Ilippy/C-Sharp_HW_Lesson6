internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите целое число");
        
        int[] array = Fibonachi(number);
        System.Console.WriteLine($"[{String.Join(", ", array)}]");
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

    static int[] Fibonachi(int size)
    {
        int[] array = new int[size];
        array[0] = 0;
        array[1] = 1;
        for (int i = 2; i < size; i++)
        {
            array[i] = array[i-1] + array[i-2];
        }
        return array;
    }
}