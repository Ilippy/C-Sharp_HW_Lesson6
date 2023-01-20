// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        double b1 = Numbers.EnterDoubleNumber("Введите число b1");
        double k1 = Numbers.EnterDoubleNumber("Введите число k1");
        double b2 = Numbers.EnterDoubleNumber("Введите число b2");
        double k2 = Numbers.EnterDoubleNumber("Введите число k2");

        ShowCoordinates(b1, b2, k1, k2);


    }

    static void ShowCoordinates(double b1, double b2, double k1, double k2)
    {
        Console.Clear();
        string result;
        if (isParallel(k1, k2)) result = "линии параллельны";
        else
        {
            double x = FindX(b1, b2, k1, k2);
            double y = FindY(b1, b2, k1, k2);
            result = $"{x}; {y}";
        }
        System.Console.WriteLine("Заданное уравнение y = k1 * x + b1, y = k2 * x + b2");
        System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({result})");
    }

    static double FindX(double b1, double b2, double k1, double k2)
    {
        return (b2 - b1) / (k1 - k2);
    }

    static double FindY(double b1, double b2, double k1, double k2)
    {
        return k1 * ((b2 - b1) / (k1 - k2)) + b1;
    }

    static bool isParallel(double k1, double k2)
    {
        return k1 == k2;
    }
}