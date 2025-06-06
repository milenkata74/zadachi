using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Въведи вектори (всеки от 3 числа), разделени с интервал: ");
        var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

        if (input.Length % 3 != 0)
        {
            Console.WriteLine("Грешен брой координати.");
            return;
        }

        double minLength = double.MaxValue;
        int count = input.Length / 3;
        for (int i = 0; i < count; i++)
        {
            double x = input[i * 3];
            double y = input[i * 3 + 1];
            double z = input[i * 3 + 2];
            double length = Math.Sqrt(x * x + y * y + z * z);
            if (length < minLength)
                minLength = length;
        }

        Console.WriteLine($"Най-късият вектор има дължина: {minLength:F2}");
    }
}
