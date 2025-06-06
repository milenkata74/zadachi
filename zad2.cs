using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Въведи числа, разделени с интервал: ");
        var nums = Console.ReadLine().Split().Select(double.Parse).ToList();

        double average = nums.Average();
        double median = nums.OrderBy(x => x).ElementAt(nums.Count / 2);
        double mode = nums.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;

        Console.WriteLine($"Средно аритметично: {average:F2}");
        Console.WriteLine($"Медиана: {median}");
        Console.WriteLine($"Мода: {mode}");
    }
}
