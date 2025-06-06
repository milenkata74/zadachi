using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Въведи първо множество:");
        var set1 = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

        Console.WriteLine("Въведи второ множество:");
        var set2 = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

        var union = set1.Union(set2);
        var intersect = set1.Intersect(set2);
        var diff = set1.Except(set2);
        var symDiff = union.Except(intersect);

        Console.WriteLine("Сечение: " + string.Join(" ", intersect));
        Console.WriteLine("Обединение: " + string.Join(" ", union));
        Console.WriteLine("Разлика: " + string.Join(" ", diff));
        Console.WriteLine("Допълнение: " + string.Join(" ", symDiff));
    }
}
